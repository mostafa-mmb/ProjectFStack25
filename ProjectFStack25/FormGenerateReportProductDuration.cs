using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFStack25
{
    public partial class FormGenerateReportProductDuration : Form
    {
        FStack25 fStack;
        public FormGenerateReportProductDuration()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxWarehouse.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var warehouse = (from w in fStack.Warehouses where w.Name == cmboBxWarehouse.Text select w).FirstOrDefault();

            if (warehouse != null)
            {
                int minDaysInWarehouse = (int)nmrcUpDwnMinDays.Value;


                //--------------------------------------------------------------------------------------------

                var now = DateTime.Now;

                var productAgedQuantities = fStack.SupplyOrderItems
                    .Where(soi => soi.SupplyOrder.Warehouse.ID == warehouse.ID)
                    .Select(soi => new
                    {
                        ProductId = soi.Product.ID,
                        ProductCode = soi.Product.Code,
                        ProductName = soi.Product.Name,
                        soi.Quantity,
                        SuppliedDate = soi.SupplyOrder.Date,
                        soi.ProductionDate,
                        soi.ExpirationDate,

                        ReleasedQty = fStack.ReleaseOrderItems
                            .Where(roi => roi.Product.ID == soi.Product.ID &&
                                          roi.ReleaseOrder.Warehouse.ID == warehouse.ID &&
                                          roi.ProductionDate == soi.ProductionDate &&
                                          roi.ExpirationDate == soi.ExpirationDate)
                            .Sum(roi => (int?)roi.Quantity) ?? 0,

                        TransferredQty = fStack.Transfers
                            .Where(t => t.Product.ID == soi.Product.ID &&
                                        t.SourceWarehouse.ID == warehouse.ID &&
                                        t.ProductionDate == soi.ProductionDate &&
                                        t.ExpirationDate == soi.ExpirationDate)
                            .Sum(t => (int?)t.Quantity) ?? 0
                    })
                    .AsEnumerable()
                    .Select(x =>
                    {
                        int remainingQty = x.Quantity - x.ReleasedQty - x.TransferredQty;
                        double daysInWarehouse = (now - x.SuppliedDate).TotalDays;

                        return new
                        {
                            x.ProductId,
                            x.ProductCode,
                            x.ProductName,
                            RemainingQuantity = remainingQty > 0 && daysInWarehouse > minDaysInWarehouse ? remainingQty : 0
                        };
                    })
                    .Where(x => x.RemainingQuantity > 0)
                    .GroupBy(x => new { x.ProductId, x.ProductCode, x.ProductName })
                    .Select(g => new
                    {
                        ProductId = g.Key.ProductId,
                        ProductCode = g.Key.ProductCode,
                        ProductName = g.Key.ProductName,
                        TotalOldQuantity = g.Sum(x => x.RemainingQuantity)
                    })
                    .ToList();




                //--------------------------------------------------------------------------------------------

                dtGrdVwReport.Rows.Clear();
                foreach (var element in productAgedQuantities)
                {
                    dtGrdVwReport.Rows.Add(element.ProductCode,
                                           element.ProductName,
                                           element.TotalOldQuantity);
                }

            }
            else
            {
                MessageBox.Show("يجب تحديد إسم المخزن");
            }
        }
    }

}

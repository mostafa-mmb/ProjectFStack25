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
    public partial class FormGenerateReportProductExpiration : Form
    {
        FStack25 fStack;
        public FormGenerateReportProductExpiration()
        {
            InitializeComponent();

            fStack = new FStack25();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int daysUntilExpire = (int)nmrcUpDwnDaysUntilExpire.Value;


            //------------------------------------------------------------------

            var now = DateTime.Now;
            var thresholdDate = now.AddDays(daysUntilExpire);

            var expiringProducts = fStack.SupplyOrderItems
                .Where(soi => soi.ExpirationDate <= thresholdDate)
                .Select(soi => new
                {
                    ProductId = soi.Product.ID,
                    ProductName = soi.Product.Name,
                    ProductCode = soi.Product.Code,
                    WarehouseId = soi.SupplyOrder.Warehouse.ID,
                    WarehouseName = soi.SupplyOrder.Warehouse.Name,
                    ProductionDate = soi.ProductionDate,
                    ExpirationDate = soi.ExpirationDate,
                    SuppliedDate = soi.SupplyOrder.Date,
                    Quantity = soi.Quantity,

                    ReleasedQty = fStack.ReleaseOrderItems
                        .Where(roi => roi.Product.ID == soi.Product.ID &&
                                      roi.ReleaseOrder.Warehouse.ID == soi.SupplyOrder.Warehouse.ID &&
                                      roi.ProductionDate == soi.ProductionDate &&
                                      roi.ExpirationDate == soi.ExpirationDate)
                        .Sum(roi => (int?)roi.Quantity) ?? 0,

                    TransferredQty = fStack.Transfers
                        .Where(t => t.Product.ID == soi.Product.ID &&
                                    t.SourceWarehouse.ID == soi.SupplyOrder.Warehouse.ID &&
                                    t.ProductionDate == soi.ProductionDate &&
                                    t.ExpirationDate == soi.ExpirationDate)
                        .Sum(t => (int?)t.Quantity) ?? 0
                })
                .AsEnumerable()
                .Select(x =>
                {
                    int remainingQty = x.Quantity - x.ReleasedQty - x.TransferredQty;
                    return new
                    {
                        x.ProductId,
                        x.ProductName,
                        x.ProductCode,
                        x.WarehouseId,
                        x.WarehouseName,
                        x.ProductionDate,
                        x.ExpirationDate,
                        RemainingQuantity = remainingQty
                    };
                })
                .Where(x => x.RemainingQuantity > 0)
                .OrderBy(x => x.ExpirationDate)
                .ToList();


            //------------------------------------------------------------------

            dtGrdVwReport.Rows.Clear();
            foreach (var element in expiringProducts)
            {
                dtGrdVwReport.Rows.Add(element.ProductCode,
                                       element.ProductName,
                                       element.RemainingQuantity,
                                       element.ExpirationDate,
                                       element.WarehouseName);
            }
        }
    }

}

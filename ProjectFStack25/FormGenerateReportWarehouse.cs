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
    public partial class FormGenerateReportWarehouse : Form
    {
        FStack25 fStack;
        public FormGenerateReportWarehouse()
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
                DateTime from = dtTmPckrFrom.Value;
                DateTime to = dtTmPckrTo.Value;


                //--------------------------------------------------------------------------------------------

                var incoming = fStack.SupplyOrderItems
                    .Where(x => x.SupplyOrder.Warehouse.ID == warehouse.ID &&
                                x.SupplyOrder.Date >= from &&
                                x.SupplyOrder.Date <= to)
                    .GroupBy(x => x.Product.ID)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        Quantity = g.Sum(x => x.Quantity)
                    });

                var outgoing = fStack.ReleaseOrderItems
                    .Where(x => x.ReleaseOrder.Warehouse.ID == warehouse.ID &&
                                x.ReleaseOrder.Date >= from &&
                                x.ReleaseOrder.Date <= to)
                    .GroupBy(x => x.Product.ID)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        Quantity = g.Sum(x => x.Quantity)
                    });

                var transferredIn = fStack.Transfers
                    .Where(x => x.DestinationWarehouse.ID == warehouse.ID &&
                                x.Date >= from &&
                                x.Date <= to)
                    .GroupBy(x => x.Product.ID)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        Quantity = g.Sum(x => x.Quantity)
                    });

                var transferredOut = fStack.Transfers
                    .Where(x => x.SourceWarehouse.ID == warehouse.ID &&
                                x.Date >= from &&
                                x.Date <= to)
                    .GroupBy(x => x.Product.ID)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        Quantity = g.Sum(x => x.Quantity)
                    });

                var report = fStack.Products
                    .Select(p => new
                    {
                        ProductCode = p.Code,
                        ProductName = p.Name,
                        Incoming = incoming.Where(i => i.ProductId == p.ID).Select(i => (int?)i.Quantity).FirstOrDefault() ?? 0,
                        Outgoing = outgoing.Where(o => o.ProductId == p.ID).Select(o => (int?)o.Quantity).FirstOrDefault() ?? 0,
                        TransferredIn = transferredIn.Where(ti => ti.ProductId == p.ID).Select(ti => (int?)ti.Quantity).FirstOrDefault() ?? 0,
                        TransferredOut = transferredOut.Where(tot => tot.ProductId == p.ID).Select(tot => (int?)tot.Quantity).FirstOrDefault() ?? 0,
                    })
                    .AsEnumerable()
                    .Select(x => new
                    {
                        x.ProductCode,
                        x.ProductName,
                        x.Incoming,
                        x.Outgoing,
                        x.TransferredIn,
                        x.TransferredOut,
                        NetQuantity = x.Incoming + x.TransferredIn - x.Outgoing - x.TransferredOut
                    })
                    .ToList();



                //--------------------------------------------------------------------------------------------

                dtGrdVwReport.Rows.Clear();
                foreach (var element in report)
                {
                    dtGrdVwReport.Rows.Add(element.ProductCode,
                                           element.ProductName,
                                           element.NetQuantity);
                }

            }
            else
            {
                MessageBox.Show("يجب تحديد إسم المخزن");
            }
        }
    }

}

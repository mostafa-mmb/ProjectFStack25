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
    public partial class FormGenerateReportProduct : Form
    {
        FStack25 fStack;

        HashSet<string> warehouseNames;
        public FormGenerateReportProduct()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxProduct.Items.AddRange((from p in fStack.Products select p.Code).ToArray());

            warehouseNames = (from w in fStack.Warehouses select w.Name).ToHashSet();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime? from = dtTmPckrFrom.Value;
            DateTime? to = dtTmPckrTo.Value;
            int selectedProductId = (from p in fStack.Products where p.Code == cmboBxProduct.Text select p.ID).FirstOrDefault();
            List<int> selectedWarehouseIds = new List<int>();
            for (int r = 0; r < dtGrdVwReport.Rows.Count; r++)
            {
                selectedWarehouseIds.Add((from w in fStack.Warehouses where w.Name == dtGrdVwReport.Rows[r].Cells[0].Value select w.ID).FirstOrDefault());
            }

            //-----------------------------------------------------------------

            var product = fStack.Products
                .Where(p => p.ID == selectedProductId)
                .Select(p => new { p.ID, p.Name, p.Code })
                .FirstOrDefault();

            var report = fStack.Warehouses
                .Where(w => selectedWarehouseIds.Contains(w.ID))
                .Select(w => new
                {
                    WarehouseName = w.Name,

                    Incoming = fStack.SupplyOrderItems
                        .Where(i => i.Product.ID == selectedProductId &&
                                    i.SupplyOrder.Warehouse.ID == w.ID &&
                                    (!from.HasValue || i.SupplyOrder.Date >= from.Value) &&
                                    (!to.HasValue || i.SupplyOrder.Date <= to.Value))
                        .Sum(i => (int?)i.Quantity) ?? 0,

                    Outgoing = fStack.ReleaseOrderItems
                        .Where(o => o.Product.ID == selectedProductId &&
                                    o.ReleaseOrder.Warehouse.ID == w.ID &&
                                    (!from.HasValue || o.ReleaseOrder.Date >= from.Value) &&
                                    (!to.HasValue || o.ReleaseOrder.Date <= to.Value))
                        .Sum(o => (int?)o.Quantity) ?? 0,

                    TransferredIn = fStack.Transfers
                        .Where(t => t.Product.ID == selectedProductId &&
                                    t.DestinationWarehouse.ID == w.ID &&
                                    (!from.HasValue || t.Date >= from.Value) &&
                                    (!to.HasValue || t.Date <= to.Value))
                        .Sum(t => (int?)t.Quantity) ?? 0,

                    TransferredOut = fStack.Transfers
                        .Where(t => t.Product.ID == selectedProductId &&
                                    t.SourceWarehouse.ID == w.ID &&
                                    (!from.HasValue || t.Date >= from.Value) &&
                                    (!to.HasValue || t.Date <= to.Value))
                        .Sum(t => (int?)t.Quantity) ?? 0,
                })
                .AsEnumerable()
                .Select(r => new
                {
                    ProductCode = product?.Code,
                    ProductName = product?.Name,
                    r.WarehouseName,
                    r.Incoming,
                    r.Outgoing,
                    r.TransferredIn,
                    r.TransferredOut,
                    NetQuantity = r.Incoming + r.TransferredIn - r.Outgoing - r.TransferredOut
                })
                .ToList();



            //-----------------------------------------------------------------

            dtGrdVwReport.Rows.Clear();
            foreach (var element in report)
            {
                dtGrdVwReport.Rows.Add(
                                       element.WarehouseName,
                                       element.Incoming,
                                       element.Outgoing,
                                       element.TransferredIn,
                                       element.TransferredOut,
                                       element.NetQuantity);
            }
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            FormSelectWarehouse formSelectWarehouse = new FormSelectWarehouse(warehouseNames);
            formSelectWarehouse.ShowDialog();
            if (formSelectWarehouse.DialogResult == DialogResult.OK)
            {
                dtGrdVwReport.Rows.Add(formSelectWarehouse.WarehouseName);
                warehouseNames.Remove(formSelectWarehouse.WarehouseName);
            }
        }
    }

}

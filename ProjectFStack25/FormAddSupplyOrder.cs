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
    public partial class FormAddSupplyOrder : Form
    {
        FStack25 fStack;
        public FormAddSupplyOrder()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxWarehouseName.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());

            cmboBxSupplierName.Items.AddRange((from s in fStack.Suppliers select s.Name).ToArray());
        }

        private void BtnAddSupplyOrder_Click(object sender, EventArgs e)
        {
            string number = txtBxNumber.Text;

            var supplyOrder = (from so in fStack.SupplyOrders where so.Number == number select so).FirstOrDefault();

            if (supplyOrder == null)
            {
                supplyOrder = new SupplyOrder();
                supplyOrder.Number = number;
                supplyOrder.Date = dtTmPckrDate.Value;
                supplyOrder.Warehouse = (from w in fStack.Warehouses where w.Name == cmboBxWarehouseName.Text select w).FirstOrDefault();
                supplyOrder.Supplier = (from s in fStack.Suppliers where s.Name == cmboBxSupplierName.Text select s).FirstOrDefault();
                for (int row = 0; row < dtGrdVwProducts.Rows.Count; row++)
                {
                    supplyOrder.SupplyOrderItems.Add(new SupplyOrderItem
                    {
                        Product = (from p in fStack.Products where p.Code == dtGrdVwProducts.Rows[row].Cells[0].Value.ToString() select p).FirstOrDefault(),
                        Quantity = int.Parse(dtGrdVwProducts.Rows[row].Cells[1].Value.ToString()),
                        ProductionDate = DateTime.Parse(dtGrdVwProducts.Rows[row].Cells[2].Value.ToString()),
                        ExpirationDate = DateTime.Parse(dtGrdVwProducts.Rows[row].Cells[3].Value.ToString()),
                        SupplyOrder = supplyOrder
                    });
                }
                fStack.SupplyOrders.Add(supplyOrder);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد إذن توريد بهذا الرقم");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var formAddSupplyOrderItem = new FormAddSupplyOrderItem();
            formAddSupplyOrderItem.ShowDialog();
            if (formAddSupplyOrderItem.DialogResult == DialogResult.OK)
            {
                dtGrdVwProducts.Rows.Add(formAddSupplyOrderItem.Code,
                                         formAddSupplyOrderItem.Quantity,
                                         formAddSupplyOrderItem.ProductionDate,
                                         formAddSupplyOrderItem.ExpirationDate);
            }
        }
    }

}

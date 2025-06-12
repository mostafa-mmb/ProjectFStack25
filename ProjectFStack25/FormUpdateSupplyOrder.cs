using Microsoft.EntityFrameworkCore;
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
    public partial class FormUpdateSupplyOrder : Form
    {
        FStack25 fStack;
        public FormUpdateSupplyOrder()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxNumber.Items.AddRange((from so in fStack.SupplyOrders select so.Number).ToArray());

            cmboBxWarehouseName.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());

            cmboBxSupplierName.Items.AddRange((from s in fStack.Suppliers select s.Name).ToArray());
        }

        private void BtnUpdateSupplyOrder_Click(object sender, EventArgs e)
        {
            string number = cmboBxNumber.Text;

            var supplyOrder = fStack.SupplyOrders.Include(so => so.SupplyOrderItems).FirstOrDefault(so => so.Number == number);

            if (supplyOrder != null)
            {
                supplyOrder.Date = dtTmPckrDate.Value;
                supplyOrder.Warehouse = (from w in fStack.Warehouses where w.Name == cmboBxWarehouseName.Text select w).FirstOrDefault();
                supplyOrder.Supplier = (from s in fStack.Suppliers where s.Name == cmboBxSupplierName.Text select s).FirstOrDefault();
                fStack.SupplyOrderItems.RemoveRange(supplyOrder.SupplyOrderItems);
                supplyOrder.SupplyOrderItems.Clear();
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
                fStack.SupplyOrders.Update(supplyOrder);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد إذن توريد بهذا الرقم");
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

        private void cmboBxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string number = cmboBxNumber.Text;

            var supplyOrder = fStack.SupplyOrders.Include(so => so.Warehouse).Include(so => so.Supplier).FirstOrDefault(so => so.Number == number);
            supplyOrder.SupplyOrderItems = fStack.SupplyOrderItems.Include(i => i.Product).Where(i => i.SupplyOrder.ID == supplyOrder.ID).ToList();

            if (supplyOrder != null)
            {
                dtTmPckrDate.Value = supplyOrder.Date;
                if (supplyOrder.Warehouse != null) cmboBxWarehouseName.Text = supplyOrder.Warehouse.Name;
                else cmboBxWarehouseName.Text = null;
                if (supplyOrder.Supplier != null) cmboBxSupplierName.Text = supplyOrder.Supplier.Name;
                else cmboBxSupplierName.Text = null;
                dtGrdVwProducts.Rows.Clear();
                foreach (var item in supplyOrder.SupplyOrderItems)
                {
                    dtGrdVwProducts.Rows.Add(item.Product.Code,
                                         item.Quantity,
                                         item.ProductionDate,
                                         item.ExpirationDate);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد إذن توريد بهذا الرقم");
            }
        }
    }

}

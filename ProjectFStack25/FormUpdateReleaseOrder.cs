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
    public partial class FormUpdateReleaseOrder : Form
    {
        FStack25 fStack;
        public FormUpdateReleaseOrder()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxNumber.Items.AddRange((from so in fStack.ReleaseOrders select so.Number).ToArray());

            cmboBxWarehouseName.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());

            cmboBxCustomerName.Items.AddRange((from c in fStack.Customers select c.Name).ToArray());
        }

        private void BtnUpdateReleaseOrder_Click(object sender, EventArgs e)
        {
            string number = cmboBxNumber.Text;

            var releaseOrder = fStack.ReleaseOrders.Include(so => so.ReleaseOrderItems).FirstOrDefault(so => so.Number == number);

            if (releaseOrder != null)
            {
                releaseOrder.Date = dtTmPckrDate.Value;
                releaseOrder.Warehouse = (from w in fStack.Warehouses where w.Name == cmboBxWarehouseName.Text select w).FirstOrDefault();
                releaseOrder.Customer = (from s in fStack.Customers where s.Name == cmboBxCustomerName.Text select s).FirstOrDefault();
                fStack.ReleaseOrderItems.RemoveRange(releaseOrder.ReleaseOrderItems);
                releaseOrder.ReleaseOrderItems.Clear();
                for (int row = 0; row < dtGrdVwProducts.Rows.Count; row++)
                {
                    releaseOrder.ReleaseOrderItems.Add(new ReleaseOrderItem
                    {
                        Product = (from p in fStack.Products where p.Code == dtGrdVwProducts.Rows[row].Cells[0].Value.ToString() select p).FirstOrDefault(),
                        Quantity = int.Parse(dtGrdVwProducts.Rows[row].Cells[1].Value.ToString()),
                        ProductionDate = DateTime.Parse(dtGrdVwProducts.Rows[row].Cells[2].Value.ToString()),
                        ExpirationDate = DateTime.Parse(dtGrdVwProducts.Rows[row].Cells[3].Value.ToString()),
                        ReleaseOrder = releaseOrder
                    });
                }
                fStack.ReleaseOrders.Update(releaseOrder);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد إذن صرف بهذا الرقم");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var formAddreleaseOrderItem = new FormAddReleaseOrderItem();
            formAddreleaseOrderItem.ShowDialog();
            if (formAddreleaseOrderItem.DialogResult == DialogResult.OK)
            {
                dtGrdVwProducts.Rows.Add(formAddreleaseOrderItem.Code,
                                         formAddreleaseOrderItem.Quantity,
                                         formAddreleaseOrderItem.ProductionDate,
                                         formAddreleaseOrderItem.ExpirationDate);
            }
        }

        private void cmboBxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string number = cmboBxNumber.Text;

            var releaseOrder = fStack.ReleaseOrders.Include(ro => ro.Warehouse).Include(ro => ro.Customer).FirstOrDefault(so => so.Number == number);
            releaseOrder.ReleaseOrderItems = fStack.ReleaseOrderItems.Include(i => i.Product).Where(i => i.ReleaseOrder.ID == releaseOrder.ID).ToList();

            if (releaseOrder != null)
            {
                dtTmPckrDate.Value = releaseOrder.Date;
                if (releaseOrder.Warehouse != null) cmboBxWarehouseName.Text = releaseOrder.Warehouse.Name;
                else cmboBxWarehouseName.Text = null;
                if (releaseOrder.Customer != null) cmboBxCustomerName.Text = releaseOrder.Customer.Name;
                else cmboBxCustomerName.Text = null;
                dtGrdVwProducts.Rows.Clear();
                foreach (var item in releaseOrder.ReleaseOrderItems)
                {
                    dtGrdVwProducts.Rows.Add(item.Product.Code,
                                         item.Quantity,
                                         item.ProductionDate,
                                         item.ExpirationDate);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد إذن صرف بهذا الرقم");
            }
        }
    }

}

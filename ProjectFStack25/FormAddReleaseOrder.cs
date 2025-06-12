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
    public partial class FormAddReleaseOrder : Form
    {
        FStack25 fStack;
        public FormAddReleaseOrder()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxWarehouseName.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());

            cmboBxCustomerName.Items.AddRange((from c in fStack.Customers select c.Name).ToArray());
        }

        private void BtnAddReleaseOrder_Click(object sender, EventArgs e)
        {
            string number = txtBxNumber.Text;

            var releaseOrder = (from ro in fStack.ReleaseOrders where ro.Number == number select ro).FirstOrDefault();

            if (releaseOrder == null)
            {
                releaseOrder = new ReleaseOrder();
                releaseOrder.Number = number;
                releaseOrder.Date = dtTmPckrDate.Value;
                releaseOrder.Warehouse = (from w in fStack.Warehouses where w.Name == cmboBxWarehouseName.Text select w).FirstOrDefault();
                releaseOrder.Customer = (from c in fStack.Customers where c.Name == cmboBxCustomerName.Text select c).FirstOrDefault();
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
                fStack.ReleaseOrders.Add(releaseOrder);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد إذن صرف بهذا الرقم");
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
    }

}

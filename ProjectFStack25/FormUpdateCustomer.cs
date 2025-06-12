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
    public partial class FormUpdateCustomer : Form
    {
        FStack25 fStack;
        public FormUpdateCustomer()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxCustomerName.Items.AddRange((from c in fStack.Customers select c.Name).ToArray());
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {


            string name = cmboBxCustomerName.Text;

            var customer = (from c in fStack.Customers where c.Name == name select c).FirstOrDefault();

            if (customer != null)
            {
                customer.Phone = txtBxPhone.Text;
                customer.Fax = txtBxFax.Text;
                customer.Mobile = txtBxMobile.Text;
                customer.Email = txtBxEmail.Text;
                customer.Website = txtBxWebSite.Text;
                fStack.Customers.Update(customer);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد عميل بهذا الإسم");
            }
        }

        private void cmboBxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cmboBxCustomerName.Text;

            var customer = (from c in fStack.Customers where c.Name == name select c).FirstOrDefault();

            if (customer != null)
            {
                txtBxPhone.Text = customer.Phone;
                txtBxFax.Text = customer.Fax;
                txtBxMobile.Text = customer.Mobile;
                txtBxEmail.Text = customer.Email;
                txtBxWebSite.Text = customer.Website;
            }
        }
    }

}

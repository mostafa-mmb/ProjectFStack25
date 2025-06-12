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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FStack25 fStack = new FStack25();

            string name = txtBxName.Text;

            var customer = (from c in fStack.Customers where c.Name == name select c).FirstOrDefault();

            if (customer == null)
            {
                customer = new Customer();
                customer.Name = name;
                customer.Phone = txtBxPhone.Text;
                customer.Fax = txtBxFax.Text;
                customer.Mobile = txtBxMobile.Text;
                customer.Email = txtBxEmail.Text;
                customer.Website = txtBxWebSite.Text;
                fStack.Customers.Add(customer);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد عميل بهذا الإسم");
            }
        }
    }

}

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
    public partial class FormUpdateSupplier : Form
    {
        FStack25 fStack;
        public FormUpdateSupplier()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxSupplierName.Items.AddRange((from s in fStack.Suppliers select s.Name).ToArray());
        }

        private void BtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            string name = cmboBxSupplierName.Text;

            var supplier = (from s in fStack.Suppliers where s.Name == name select s).FirstOrDefault();

            if (supplier != null)
            {
                supplier.Phone = txtBxPhone.Text;
                supplier.Fax = txtBxFax.Text;
                supplier.Mobile = txtBxMobile.Text;
                supplier.Email = txtBxEmail.Text;
                supplier.Website = txtBxWebSite.Text;
                fStack.Suppliers.Update(supplier);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد مورد بهذا الإسم");
            }
        }

        private void cmboBxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cmboBxSupplierName.Text;

            var supplier = (from s in fStack.Suppliers where s.Name == name select s).FirstOrDefault();

            if (supplier != null)
            {
                txtBxPhone.Text = supplier.Phone;
                txtBxFax.Text = supplier.Fax;
                txtBxMobile.Text = supplier.Mobile;
                txtBxEmail.Text = supplier.Email;
                txtBxWebSite.Text = supplier.Website;
            }
        }
    }

}

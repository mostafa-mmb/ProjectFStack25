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
    public partial class FormAddSupplier : Form
    {
        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            FStack25 fStack = new FStack25();

            string name = txtBxName.Text;

            var supplier = (from s in fStack.Suppliers where s.Name == name select s).FirstOrDefault();

            if (supplier == null)
            {
                supplier = new Supplier();
                supplier.Name = name;
                supplier.Phone = txtBxPhone.Text;
                supplier.Fax = txtBxFax.Text;
                supplier.Mobile = txtBxMobile.Text;
                supplier.Email = txtBxEmail.Text;
                supplier.Website = txtBxWebSite.Text;
                fStack.Suppliers.Add(supplier);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد مورد بهذا الإسم");
            }
        }
    }

}

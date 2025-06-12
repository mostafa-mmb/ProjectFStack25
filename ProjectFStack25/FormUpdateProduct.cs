using System;
using System.Collections;
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
    public partial class FormUpdateProduct : Form
    {
        FStack25 fStack;
        public FormUpdateProduct()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxProductCode.Items.AddRange((from p in fStack.Products select p.Code).ToArray());
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            string code = cmboBxProductCode.Text;

            var product = (from p in fStack.Products where p.Code == code select p).FirstOrDefault();

            if (product != null)
            {
                product.Name = txtBxName.Text;
                fStack.Products.Update(product);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد صنف بهذا الكود");
            }
        }

        private void cmboBxProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = cmboBxProductCode.Text;

            var product = (from p in fStack.Products where p.Code == code select p).FirstOrDefault();

            if (product != null)
            {
                txtBxName.Text = product.Name;
            }
        }
    }

}

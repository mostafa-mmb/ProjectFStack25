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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            FStack25 fStack = new FStack25();

            string code = txtBxCode.Text;

            var product = (from s in fStack.Products where s.Code == code select s).FirstOrDefault();

            if (product == null)
            {
                product = new Product();
                product.Code = code;
                product.Name = txtBxName.Text;

                fStack.Products.Add(product);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد صنف بهذا الكود");
            }
        }
    }

}

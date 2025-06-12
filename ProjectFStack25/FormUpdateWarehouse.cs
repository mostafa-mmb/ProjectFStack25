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
    public partial class FormUpdateWarehouse : Form
    {
        FStack25 fStack;
        public FormUpdateWarehouse()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxWarehouseName.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());
        }

        private void btnUpdateWarehouse_Click(object sender, EventArgs e)
        {
            string name = cmboBxWarehouseName.Text;

            var warehouse = (from w in fStack.Warehouses where w.Name == name select w).FirstOrDefault();


            if (warehouse != null)
            {
                warehouse.Address = txtBxWarehouseAddress.Text;
                warehouse.Supervisor = txtBxWarehouseSupervisor.Text;
                fStack.Warehouses.Update(warehouse);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد مخزن بهذا الإسم");
            }
        }

        private void cmboBxWarehouseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cmboBxWarehouseName.Text;

            var warehouse = (from w in fStack.Warehouses where w.Name == name select w).FirstOrDefault();


            if (warehouse != null)
            {
                txtBxWarehouseAddress.Text = warehouse.Address;
                txtBxWarehouseSupervisor.Text = warehouse.Supervisor;
            }
        }
    }

}

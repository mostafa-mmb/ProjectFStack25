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
    public partial class FormAddWarehouse : Form
    {
        public FormAddWarehouse()
        {
            InitializeComponent();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            FStack25 fStack = new FStack25();

            string name = txtBxWarehouseName.Text;

            var warehouse = (from w in fStack.Warehouses where w.Name == name select w).FirstOrDefault();

            if (warehouse == null)
            {
                warehouse = new Warehouse();
                warehouse.Name = name;
                warehouse.Address = txtBxWarehouseAddress.Text;
                warehouse.Supervisor = txtBxWarehouseSupervisor.Text;
                fStack.Warehouses.Add(warehouse);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد مخزن بهذا الإسم");
            }
        }
    }

}

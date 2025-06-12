﻿using System;
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
    public partial class FormSelectWarehouse : Form
    {
        public string WarehouseName { get; set; }
        public FormSelectWarehouse(HashSet<string> warehouseNames)
        {
            InitializeComponent();

            cmboBxWarehouse.Items.AddRange(warehouseNames.ToArray());
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseName = cmboBxWarehouse.Text;
            if (WarehouseName != null && WarehouseName != "") this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}

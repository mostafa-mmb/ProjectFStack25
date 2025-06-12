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
    public partial class FormAddReleaseOrderItem : Form
    {
        public string Code { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        private FStack25 fStack;
        public FormAddReleaseOrderItem()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxCode.Items.AddRange((from p in fStack.Products select p.Code).ToArray());
        }

        private void btnAddSupplyItem_Click(object sender, EventArgs e)
        {
            Code = cmboBxCode.Text;
            Quantity = (int)nmrcUpDwnQuantity.Value;
            ProductionDate = dtTmPckrProductionDate.Value.Date;
            ExpirationDate = dtTmPckrExpirationDate.Value.Date;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}

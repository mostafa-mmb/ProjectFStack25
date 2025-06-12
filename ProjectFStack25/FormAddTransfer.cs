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
    public partial class FormAddTransfer : Form
    {
        FStack25 fStack;
        public FormAddTransfer()
        {
            InitializeComponent();

            fStack = new FStack25();

            cmboBxCode.Items.AddRange((from p in fStack.Products select p.Code).ToArray());

            cmboBxSourceWarehouse.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());

            cmboBxDestinationWarehouse.Items.AddRange((from w in fStack.Warehouses select w.Name).ToArray());
        }

        private void btnAddTransfer_Click(object sender, EventArgs e)
        {
            var product = (from s in fStack.Products where s.Code == cmboBxCode.Text select s).FirstOrDefault();
            var sourceWarehouse = (from sw in fStack.Warehouses where sw.Name == cmboBxSourceWarehouse.Text select sw).FirstOrDefault();
            var destinationWarehouse = (from dw in fStack.Warehouses where dw.Name == cmboBxDestinationWarehouse.Text select dw).FirstOrDefault();

            if (product != null && sourceWarehouse != null && destinationWarehouse != null)
            {
                Transfer transfer = new Transfer()
                {
                    Product = product,
                    Quantity = (int)nmrcUpDwnQuantity.Value,
                    ProductionDate = dtTmPckrProductionDate.Value,
                    ExpirationDate = dtTmPckrExpirationDate.Value,
                    Date = dtTmPckrDate.Value,
                    SourceWarehouse = sourceWarehouse,
                    DestinationWarehouse = destinationWarehouse
                };

                fStack.Transfers.Add(transfer);
                fStack.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("يجب تحديد كود الصنف و أسماء المخازن من و إلى");
            }
        }
    }

}

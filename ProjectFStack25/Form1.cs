namespace ProjectFStack25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            new FormAddWarehouse().Show();
        }

        private void btnUpdateWarehouse_Click(object sender, EventArgs e)
        {
            new FormUpdateWarehouse().Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            new FormAddSupplier().Show();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            new FormUpdateSupplier().Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new FormAddCustomer().Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            new FormUpdateCustomer().Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new FormAddProduct().Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            new FormUpdateProduct().Show();
        }

        private void btnAddSupplyOrder_Click(object sender, EventArgs e)
        {
            new FormAddSupplyOrder().Show();
        }

        private void btnUpdateSupplyOrder_Click(object sender, EventArgs e)
        {
            new FormUpdateSupplyOrder().Show();
        }

        private void btnAddReleaseOrder_Click(object sender, EventArgs e)
        {
            new FormAddReleaseOrder().Show();
        }

        private void btnUpdateReleaseOrder_Click(object sender, EventArgs e)
        {
            new FormUpdateReleaseOrder().Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            new FormAddTransfer().Show();
        }

        private void btnGetWarehouseReport_Click(object sender, EventArgs e)
        {
            new FormGenerateReportWarehouse().Show();
        }

        private void btnGetProductReport_Click(object sender, EventArgs e)
        {
            new FormGenerateReportProduct().Show();
        }

        private void btnGetProductDurationReport_Click(object sender, EventArgs e)
        {
            new FormGenerateReportProductDuration().Show();
        }

        private void btnGetProductExpirationReport_Click(object sender, EventArgs e)
        {
            new FormGenerateReportProductExpiration().Show();
        }
    }
}

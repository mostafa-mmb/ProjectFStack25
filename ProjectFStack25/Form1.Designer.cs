namespace ProjectFStack25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        //-----------------------------------------------------------------------
        // original code
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Form1";
        //}
        //------------------------------------------------------------------------
        private void InitializeComponent()
        {
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.btnUpdateWarehouse = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddSupplyOrder = new System.Windows.Forms.Button();
            this.btnUpdateSupplyOrder = new System.Windows.Forms.Button();
            this.btnUpdateReleaseOrder = new System.Windows.Forms.Button();
            this.btnAddReleaseOrder = new System.Windows.Forms.Button();
            this.btnGetProductDurationReport = new System.Windows.Forms.Button();
            this.btnGetProductExpirationReport = new System.Windows.Forms.Button();
            this.btnGetProductReport = new System.Windows.Forms.Button();
            this.btnGetWarehouseReport = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(674, 22);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(101, 23);
            this.btnAddWarehouse.TabIndex = 0;
            this.btnAddWarehouse.Text = "إضافة مخزن";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // btnUpdateWarehouse
            // 
            this.btnUpdateWarehouse.Location = new System.Drawing.Point(515, 22);
            this.btnUpdateWarehouse.Name = "btnUpdateWarehouse";
            this.btnUpdateWarehouse.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateWarehouse.TabIndex = 1;
            this.btnUpdateWarehouse.Text = "تعديل مخزن";
            this.btnUpdateWarehouse.UseVisualStyleBackColor = true;
            this.btnUpdateWarehouse.Click += new System.EventHandler(this.btnUpdateWarehouse_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(674, 80);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(101, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "إضافة صنف";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(515, 80);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "تعديل صنف";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(674, 136);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(101, 23);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "إضافة مورد";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(515, 136);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateSupplier.TabIndex = 5;
            this.btnUpdateSupplier.Text = "تعديل مورد";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(674, 199);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(101, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "إضافة عميل";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(515, 199);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateCustomer.TabIndex = 7;
            this.btnUpdateCustomer.Text = "تعديل عميل";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddSupplyOrder
            // 
            this.btnAddSupplyOrder.Location = new System.Drawing.Point(674, 253);
            this.btnAddSupplyOrder.Name = "btnAddSupplyOrder";
            this.btnAddSupplyOrder.Size = new System.Drawing.Size(101, 23);
            this.btnAddSupplyOrder.TabIndex = 8;
            this.btnAddSupplyOrder.Text = "إضافة إذن توريد";
            this.btnAddSupplyOrder.UseVisualStyleBackColor = true;
            this.btnAddSupplyOrder.Click += new System.EventHandler(this.btnAddSupplyOrder_Click);
            // 
            // btnUpdateSupplyOrder
            // 
            this.btnUpdateSupplyOrder.Location = new System.Drawing.Point(515, 253);
            this.btnUpdateSupplyOrder.Name = "btnUpdateSupplyOrder";
            this.btnUpdateSupplyOrder.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateSupplyOrder.TabIndex = 9;
            this.btnUpdateSupplyOrder.Text = "تعديل إذن توريد";
            this.btnUpdateSupplyOrder.UseVisualStyleBackColor = true;
            this.btnUpdateSupplyOrder.Click += new System.EventHandler(this.btnUpdateSupplyOrder_Click);
            // 
            // btnUpdateReleaseOrder
            // 
            this.btnUpdateReleaseOrder.Location = new System.Drawing.Point(515, 307);
            this.btnUpdateReleaseOrder.Name = "btnUpdateReleaseOrder";
            this.btnUpdateReleaseOrder.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateReleaseOrder.TabIndex = 10;
            this.btnUpdateReleaseOrder.Text = "تعديل إذن صرف";
            this.btnUpdateReleaseOrder.UseVisualStyleBackColor = true;
            this.btnUpdateReleaseOrder.Click += new System.EventHandler(this.btnUpdateReleaseOrder_Click);
            // 
            // btnAddReleaseOrder
            // 
            this.btnAddReleaseOrder.Location = new System.Drawing.Point(674, 307);
            this.btnAddReleaseOrder.Name = "btnAddReleaseOrder";
            this.btnAddReleaseOrder.Size = new System.Drawing.Size(101, 23);
            this.btnAddReleaseOrder.TabIndex = 11;
            this.btnAddReleaseOrder.Text = "إضافة إذن صرف";
            this.btnAddReleaseOrder.UseVisualStyleBackColor = true;
            this.btnAddReleaseOrder.Click += new System.EventHandler(this.btnAddReleaseOrder_Click);
            // 
            // btnGetProductDurationReport
            // 
            this.btnGetProductDurationReport.Location = new System.Drawing.Point(54, 136);
            this.btnGetProductDurationReport.Name = "btnGetProductDurationReport";
            this.btnGetProductDurationReport.Size = new System.Drawing.Size(269, 23);
            this.btnGetProductDurationReport.TabIndex = 12;
            this.btnGetProductDurationReport.Text = "تقرير عن أصناف مر عليها فترة زمنية";
            this.btnGetProductDurationReport.UseVisualStyleBackColor = true;
            this.btnGetProductDurationReport.Click += new System.EventHandler(this.btnGetProductDurationReport_Click);
            // 
            // btnGetProductExpirationReport
            // 
            this.btnGetProductExpirationReport.Location = new System.Drawing.Point(54, 199);
            this.btnGetProductExpirationReport.Name = "btnGetProductExpirationReport";
            this.btnGetProductExpirationReport.Size = new System.Drawing.Size(269, 23);
            this.btnGetProductExpirationReport.TabIndex = 13;
            this.btnGetProductExpirationReport.Text = "تقرير عن أصناف قاربت انتهاء الصلاحية";
            this.btnGetProductExpirationReport.UseVisualStyleBackColor = true;
            this.btnGetProductExpirationReport.Click += new System.EventHandler(this.btnGetProductExpirationReport_Click);
            // 
            // btnGetProductReport
            // 
            this.btnGetProductReport.Location = new System.Drawing.Point(54, 80);
            this.btnGetProductReport.Name = "btnGetProductReport";
            this.btnGetProductReport.Size = new System.Drawing.Size(269, 23);
            this.btnGetProductReport.TabIndex = 15;
            this.btnGetProductReport.Text = "تقرير عن الصنف و عن حركته";
            this.btnGetProductReport.UseVisualStyleBackColor = true;
            this.btnGetProductReport.Click += new System.EventHandler(this.btnGetProductReport_Click);
            // 
            // btnGetWarehouseReport
            // 
            this.btnGetWarehouseReport.Location = new System.Drawing.Point(54, 22);
            this.btnGetWarehouseReport.Name = "btnGetWarehouseReport";
            this.btnGetWarehouseReport.Size = new System.Drawing.Size(269, 23);
            this.btnGetWarehouseReport.TabIndex = 16;
            this.btnGetWarehouseReport.Text = "تقرير عن مخزن";
            this.btnGetWarehouseReport.UseVisualStyleBackColor = true;
            this.btnGetWarehouseReport.Click += new System.EventHandler(this.btnGetWarehouseReport_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(515, 371);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(260, 23);
            this.btnTransfer.TabIndex = 17;
            this.btnTransfer.Text = "تحويل صنف من مخزن إلى مخزن";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnGetWarehouseReport);
            this.Controls.Add(this.btnGetProductReport);
            this.Controls.Add(this.btnGetProductExpirationReport);
            this.Controls.Add(this.btnGetProductDurationReport);
            this.Controls.Add(this.btnAddReleaseOrder);
            this.Controls.Add(this.btnUpdateReleaseOrder);
            this.Controls.Add(this.btnUpdateSupplyOrder);
            this.Controls.Add(this.btnAddSupplyOrder);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnUpdateWarehouse);
            this.Controls.Add(this.btnAddWarehouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Button btnUpdateWarehouse;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddSupplyOrder;
        private System.Windows.Forms.Button btnUpdateSupplyOrder;
        private System.Windows.Forms.Button btnUpdateReleaseOrder;
        private System.Windows.Forms.Button btnAddReleaseOrder;
        private System.Windows.Forms.Button btnGetProductDurationReport;
        private System.Windows.Forms.Button btnGetProductExpirationReport;
        private System.Windows.Forms.Button btnGetProductReport;
        private System.Windows.Forms.Button btnGetWarehouseReport;
        private System.Windows.Forms.Button btnTransfer;
    }
}

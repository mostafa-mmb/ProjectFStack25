namespace ProjectFStack25
{
    partial class FormAddSupplyOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtGrdVwProducts = new DataGridView();
            clmnCode = new DataGridViewTextBoxColumn();
            clmnQuantity = new DataGridViewTextBoxColumn();
            clmnProductionDate = new DataGridViewTextBoxColumn();
            clmnExpirationDate = new DataGridViewTextBoxColumn();
            cmboBxSupplierName = new ComboBox();
            cmboBxWarehouseName = new ComboBox();
            dtTmPckrDate = new DateTimePicker();
            BtnAddSupplyOrder = new Button();
            txtBxNumber = new TextBox();
            lblSupplierName = new Label();
            lblWarehouseName = new Label();
            lblDate = new Label();
            lblNumber = new Label();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwProducts).BeginInit();
            SuspendLayout();
            // 
            // dtGrdVwProducts
            // 
            dtGrdVwProducts.AllowUserToAddRows = false;
            dtGrdVwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwProducts.Columns.AddRange(new DataGridViewColumn[] { clmnCode, clmnQuantity, clmnProductionDate, clmnExpirationDate });
            dtGrdVwProducts.Location = new Point(27, 90);
            dtGrdVwProducts.Margin = new Padding(4, 3, 4, 3);
            dtGrdVwProducts.Name = "dtGrdVwProducts";
            dtGrdVwProducts.ReadOnly = true;
            dtGrdVwProducts.RightToLeft = RightToLeft.Yes;
            dtGrdVwProducts.Size = new Size(444, 173);
            dtGrdVwProducts.TabIndex = 62;
            // 
            // clmnCode
            // 
            clmnCode.HeaderText = "كود الصنف";
            clmnCode.Name = "clmnCode";
            clmnCode.ReadOnly = true;
            // 
            // clmnQuantity
            // 
            clmnQuantity.HeaderText = "الكمية";
            clmnQuantity.Name = "clmnQuantity";
            clmnQuantity.ReadOnly = true;
            // 
            // clmnProductionDate
            // 
            clmnProductionDate.HeaderText = "تاريخ الإنتاج";
            clmnProductionDate.Name = "clmnProductionDate";
            clmnProductionDate.ReadOnly = true;
            // 
            // clmnExpirationDate
            // 
            clmnExpirationDate.HeaderText = "تاريخ الانتهاء";
            clmnExpirationDate.Name = "clmnExpirationDate";
            clmnExpirationDate.ReadOnly = true;
            // 
            // cmboBxSupplierName
            // 
            cmboBxSupplierName.FormattingEnabled = true;
            cmboBxSupplierName.Location = new Point(628, 245);
            cmboBxSupplierName.Margin = new Padding(4, 3, 4, 3);
            cmboBxSupplierName.Name = "cmboBxSupplierName";
            cmboBxSupplierName.Size = new Size(176, 23);
            cmboBxSupplierName.TabIndex = 61;
            // 
            // cmboBxWarehouseName
            // 
            cmboBxWarehouseName.FormattingEnabled = true;
            cmboBxWarehouseName.Location = new Point(628, 190);
            cmboBxWarehouseName.Margin = new Padding(4, 3, 4, 3);
            cmboBxWarehouseName.Name = "cmboBxWarehouseName";
            cmboBxWarehouseName.Size = new Size(176, 23);
            cmboBxWarehouseName.TabIndex = 60;
            // 
            // dtTmPckrDate
            // 
            dtTmPckrDate.Location = new Point(628, 137);
            dtTmPckrDate.Margin = new Padding(4, 3, 4, 3);
            dtTmPckrDate.Name = "dtTmPckrDate";
            dtTmPckrDate.Size = new Size(176, 23);
            dtTmPckrDate.TabIndex = 59;
            // 
            // BtnAddSupplyOrder
            // 
            BtnAddSupplyOrder.Location = new Point(628, 403);
            BtnAddSupplyOrder.Margin = new Padding(4, 3, 4, 3);
            BtnAddSupplyOrder.Name = "BtnAddSupplyOrder";
            BtnAddSupplyOrder.Size = new Size(104, 27);
            BtnAddSupplyOrder.TabIndex = 58;
            BtnAddSupplyOrder.Text = "أضف إذن توريد";
            BtnAddSupplyOrder.UseVisualStyleBackColor = true;
            BtnAddSupplyOrder.Click += BtnAddSupplyOrder_Click;
            // 
            // txtBxNumber
            // 
            txtBxNumber.Location = new Point(628, 92);
            txtBxNumber.Margin = new Padding(4, 3, 4, 3);
            txtBxNumber.Name = "txtBxNumber";
            txtBxNumber.Size = new Size(176, 23);
            txtBxNumber.TabIndex = 57;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(839, 248);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(60, 15);
            lblSupplierName.TabIndex = 56;
            lblSupplierName.Text = "إسم المورد";
            // 
            // lblWarehouseName
            // 
            lblWarehouseName.AutoSize = true;
            lblWarehouseName.Location = new Point(839, 194);
            lblWarehouseName.Margin = new Padding(4, 0, 4, 0);
            lblWarehouseName.Name = "lblWarehouseName";
            lblWarehouseName.Size = new Size(64, 15);
            lblWarehouseName.TabIndex = 55;
            lblWarehouseName.Text = "إسم المخزن";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(839, 144);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 15);
            lblDate.TabIndex = 54;
            lblDate.Text = "تاريخ الإذن";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(839, 96);
            lblNumber.Margin = new Padding(4, 0, 4, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(51, 15);
            lblNumber.TabIndex = 53;
            lblNumber.Text = "رقم الإذن";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(454, 283);
            btnAddProduct.Margin = new Padding(4, 3, 4, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(88, 27);
            btnAddProduct.TabIndex = 63;
            btnAddProduct.Text = "أضف صنف";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // FormAddSupplyOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dtGrdVwProducts);
            Controls.Add(cmboBxSupplierName);
            Controls.Add(cmboBxWarehouseName);
            Controls.Add(dtTmPckrDate);
            Controls.Add(BtnAddSupplyOrder);
            Controls.Add(txtBxNumber);
            Controls.Add(lblSupplierName);
            Controls.Add(lblWarehouseName);
            Controls.Add(lblDate);
            Controls.Add(lblNumber);
            Controls.Add(btnAddProduct);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAddSupplyOrder";
            Text = "إضافة إذن توريد";
            ((System.ComponentModel.ISupportInitialize)dtGrdVwProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnExpirationDate;
        private System.Windows.Forms.ComboBox cmboBxSupplierName;
        private System.Windows.Forms.ComboBox cmboBxWarehouseName;
        private System.Windows.Forms.DateTimePicker dtTmPckrDate;
        private System.Windows.Forms.Button BtnAddSupplyOrder;
        private System.Windows.Forms.TextBox txtBxNumber;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnAddProduct;

    }
}
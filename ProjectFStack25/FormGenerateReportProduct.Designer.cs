namespace ProjectFStack25
{
    partial class FormGenerateReportProduct
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
            btnGenerateReport = new Button();
            dtGrdVwReport = new DataGridView();
            clmnWarehouseName = new DataGridViewTextBoxColumn();
            clmnSuppliedQuantity = new DataGridViewTextBoxColumn();
            clmnReleasedQuantity = new DataGridViewTextBoxColumn();
            clmnTransferedInQuantity = new DataGridViewTextBoxColumn();
            clmnTransferedOutQuantity = new DataGridViewTextBoxColumn();
            clmnNetQuantity = new DataGridViewTextBoxColumn();
            lblFrom = new Label();
            lblTo = new Label();
            lblPeriod = new Label();
            dtTmPckrFrom = new DateTimePicker();
            dtTmPckrTo = new DateTimePicker();
            lblProduct = new Label();
            cmboBxProduct = new ComboBox();
            btnAddWarehouse = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(752, 202);
            btnGenerateReport.Margin = new Padding(4, 3, 4, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(88, 27);
            btnGenerateReport.TabIndex = 80;
            btnGenerateReport.Text = "التقرير";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtGrdVwReport
            // 
            dtGrdVwReport.AllowUserToAddRows = false;
            dtGrdVwReport.AllowUserToDeleteRows = false;
            dtGrdVwReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwReport.Columns.AddRange(new DataGridViewColumn[] { clmnWarehouseName, clmnSuppliedQuantity, clmnReleasedQuantity, clmnTransferedInQuantity, clmnTransferedOutQuantity, clmnNetQuantity });
            dtGrdVwReport.Location = new Point(197, 263);
            dtGrdVwReport.Margin = new Padding(4, 3, 4, 3);
            dtGrdVwReport.Name = "dtGrdVwReport";
            dtGrdVwReport.ReadOnly = true;
            dtGrdVwReport.RightToLeft = RightToLeft.Yes;
            dtGrdVwReport.Size = new Size(643, 275);
            dtGrdVwReport.TabIndex = 79;
            // 
            // clmnWarehouseName
            // 
            clmnWarehouseName.HeaderText = "إسم المخزن";
            clmnWarehouseName.Name = "clmnWarehouseName";
            clmnWarehouseName.ReadOnly = true;
            // 
            // clmnSuppliedQuantity
            // 
            clmnSuppliedQuantity.HeaderText = "الكمية الموردة";
            clmnSuppliedQuantity.Name = "clmnSuppliedQuantity";
            clmnSuppliedQuantity.ReadOnly = true;
            // 
            // clmnReleasedQuantity
            // 
            clmnReleasedQuantity.HeaderText = "الكمية المصروفة";
            clmnReleasedQuantity.Name = "clmnReleasedQuantity";
            clmnReleasedQuantity.ReadOnly = true;
            // 
            // clmnTransferedInQuantity
            // 
            clmnTransferedInQuantity.HeaderText = "الكمية المحولة إلى المخزن";
            clmnTransferedInQuantity.Name = "clmnTransferedInQuantity";
            clmnTransferedInQuantity.ReadOnly = true;
            // 
            // clmnTransferedOutQuantity
            // 
            clmnTransferedOutQuantity.HeaderText = "الكمية المحولة من المخزن";
            clmnTransferedOutQuantity.Name = "clmnTransferedOutQuantity";
            clmnTransferedOutQuantity.ReadOnly = true;
            // 
            // clmnNetQuantity
            // 
            clmnNetQuantity.HeaderText = "الكمية الكلية";
            clmnNetQuantity.Name = "clmnNetQuantity";
            clmnNetQuantity.ReadOnly = true;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(274, 43);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(22, 15);
            lblFrom.TabIndex = 78;
            lblFrom.Text = "من";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(274, 87);
            lblTo.Margin = new Padding(4, 0, 4, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(24, 15);
            lblTo.TabIndex = 77;
            lblTo.Text = "إلى";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new Point(335, 43);
            lblPeriod.Margin = new Padding(4, 0, 4, 0);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(37, 15);
            lblPeriod.TabIndex = 76;
            lblPeriod.Text = ":الفترة";
            // 
            // dtTmPckrFrom
            // 
            dtTmPckrFrom.Location = new Point(91, 39);
            dtTmPckrFrom.Margin = new Padding(4, 3, 4, 3);
            dtTmPckrFrom.Name = "dtTmPckrFrom";
            dtTmPckrFrom.Size = new Size(176, 23);
            dtTmPckrFrom.TabIndex = 75;
            // 
            // dtTmPckrTo
            // 
            dtTmPckrTo.Location = new Point(91, 80);
            dtTmPckrTo.Margin = new Padding(4, 3, 4, 3);
            dtTmPckrTo.Name = "dtTmPckrTo";
            dtTmPckrTo.Size = new Size(176, 23);
            dtTmPckrTo.TabIndex = 74;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(775, 43);
            lblProduct.Margin = new Padding(4, 0, 4, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(63, 15);
            lblProduct.TabIndex = 73;
            lblProduct.Text = "كود الصنف";
            // 
            // cmboBxProduct
            // 
            cmboBxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxProduct.FormattingEnabled = true;
            cmboBxProduct.Location = new Point(592, 39);
            cmboBxProduct.Margin = new Padding(4, 3, 4, 3);
            cmboBxProduct.Name = "cmboBxProduct";
            cmboBxProduct.Size = new Size(176, 23);
            cmboBxProduct.TabIndex = 72;
            // 
            // btnAddWarehouse
            // 
            btnAddWarehouse.Location = new Point(752, 135);
            btnAddWarehouse.Margin = new Padding(4, 3, 4, 3);
            btnAddWarehouse.Name = "btnAddWarehouse";
            btnAddWarehouse.Size = new Size(88, 27);
            btnAddWarehouse.TabIndex = 81;
            btnAddWarehouse.Text = "أضف مخزن";
            btnAddWarehouse.UseVisualStyleBackColor = true;
            btnAddWarehouse.Click += btnAddWarehouse_Click;
            // 
            // FormGenerateReportProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 622);
            Controls.Add(btnAddWarehouse);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtGrdVwReport);
            Controls.Add(lblFrom);
            Controls.Add(lblTo);
            Controls.Add(lblPeriod);
            Controls.Add(dtTmPckrFrom);
            Controls.Add(dtTmPckrTo);
            Controls.Add(lblProduct);
            Controls.Add(cmboBxProduct);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGenerateReportProduct";
            Text = "تقرير عن صنف";
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dtGrdVwReport;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dtTmPckrFrom;
        private System.Windows.Forms.DateTimePicker dtTmPckrTo;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmboBxProduct;
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSuppliedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReleasedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTransferedInQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTransferedOutQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNetQuantity;

    }
}
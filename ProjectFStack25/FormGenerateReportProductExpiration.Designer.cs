namespace ProjectFStack25
{
    partial class FormGenerateReportProductExpiration
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
            dtGrdVwReport = new DataGridView();
            clmnCode = new DataGridViewTextBoxColumn();
            clmnName = new DataGridViewTextBoxColumn();
            clmnQuantity = new DataGridViewTextBoxColumn();
            clmnExpirationDate = new DataGridViewTextBoxColumn();
            clmnWarehouseName = new DataGridViewTextBoxColumn();
            btnGenerateReport = new Button();
            lblDaysUntilExpire = new Label();
            nmrcUpDwnDaysUntilExpire = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnDaysUntilExpire).BeginInit();
            SuspendLayout();
            // 
            // dtGrdVwReport
            // 
            dtGrdVwReport.AllowUserToAddRows = false;
            dtGrdVwReport.AllowUserToDeleteRows = false;
            dtGrdVwReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwReport.Columns.AddRange(new DataGridViewColumn[] { clmnCode, clmnName, clmnQuantity, clmnExpirationDate, clmnWarehouseName });
            dtGrdVwReport.Location = new Point(125, 125);
            dtGrdVwReport.Margin = new Padding(4, 3, 4, 3);
            dtGrdVwReport.Name = "dtGrdVwReport";
            dtGrdVwReport.ReadOnly = true;
            dtGrdVwReport.RightToLeft = RightToLeft.Yes;
            dtGrdVwReport.Size = new Size(544, 275);
            dtGrdVwReport.TabIndex = 75;
            // 
            // clmnCode
            // 
            clmnCode.HeaderText = "كود الصنف";
            clmnCode.Name = "clmnCode";
            clmnCode.ReadOnly = true;
            // 
            // clmnName
            // 
            clmnName.HeaderText = "إسم الصنف";
            clmnName.Name = "clmnName";
            clmnName.ReadOnly = true;
            // 
            // clmnQuantity
            // 
            clmnQuantity.HeaderText = "الكمية";
            clmnQuantity.Name = "clmnQuantity";
            clmnQuantity.ReadOnly = true;
            // 
            // clmnExpirationDate
            // 
            clmnExpirationDate.HeaderText = "تاريخ الإنتهاء";
            clmnExpirationDate.Name = "clmnExpirationDate";
            clmnExpirationDate.ReadOnly = true;
            // 
            // clmnWarehouseName
            // 
            clmnWarehouseName.HeaderText = "إسم المخزن";
            clmnWarehouseName.Name = "clmnWarehouseName";
            clmnWarehouseName.ReadOnly = true;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(581, 76);
            btnGenerateReport.Margin = new Padding(4, 3, 4, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(88, 27);
            btnGenerateReport.TabIndex = 76;
            btnGenerateReport.Text = "التقرير";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // lblDaysUntilExpire
            // 
            lblDaysUntilExpire.AutoSize = true;
            lblDaysUntilExpire.Location = new Point(485, 23);
            lblDaysUntilExpire.Margin = new Padding(4, 0, 4, 0);
            lblDaysUntilExpire.Name = "lblDaysUntilExpire";
            lblDaysUntilExpire.Size = new Size(162, 15);
            lblDaysUntilExpire.TabIndex = 77;
            lblDaysUntilExpire.Text = "الأيام الباقية حتى إنتهاء الصلاحية";
            // 
            // nmrcUpDwnDaysUntilExpire
            // 
            nmrcUpDwnDaysUntilExpire.Location = new Point(322, 21);
            nmrcUpDwnDaysUntilExpire.Margin = new Padding(4, 3, 4, 3);
            nmrcUpDwnDaysUntilExpire.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrcUpDwnDaysUntilExpire.Name = "nmrcUpDwnDaysUntilExpire";
            nmrcUpDwnDaysUntilExpire.Size = new Size(140, 23);
            nmrcUpDwnDaysUntilExpire.TabIndex = 78;
            // 
            // FormGenerateReportProductExpiration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(nmrcUpDwnDaysUntilExpire);
            Controls.Add(lblDaysUntilExpire);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtGrdVwReport);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGenerateReportProductExpiration";
            Text = "تقرير أصناف قاربت مدة انتهاء الصلاحية";
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnDaysUntilExpire).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWarehouseName;
        private System.Windows.Forms.Label lblDaysUntilExpire;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnDaysUntilExpire;

    }
}
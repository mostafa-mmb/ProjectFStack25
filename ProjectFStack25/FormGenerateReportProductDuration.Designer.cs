namespace ProjectFStack25
{
    partial class FormGenerateReportProductDuration
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
            clmnCode = new DataGridViewTextBoxColumn();
            clmnName = new DataGridViewTextBoxColumn();
            clmnQuantity = new DataGridViewTextBoxColumn();
            lblWarehouse = new Label();
            cmboBxWarehouse = new ComboBox();
            nmrcUpDwnMinDays = new NumericUpDown();
            lblMinDays = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnMinDays).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(580, 160);
            btnGenerateReport.Margin = new Padding(4, 3, 4, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(88, 27);
            btnGenerateReport.TabIndex = 75;
            btnGenerateReport.Text = "التقرير";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtGrdVwReport
            // 
            dtGrdVwReport.AllowUserToAddRows = false;
            dtGrdVwReport.AllowUserToDeleteRows = false;
            dtGrdVwReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwReport.Columns.AddRange(new DataGridViewColumn[] { clmnCode, clmnName, clmnQuantity });
            dtGrdVwReport.Location = new Point(326, 205);
            dtGrdVwReport.Margin = new Padding(4, 3, 4, 3);
            dtGrdVwReport.Name = "dtGrdVwReport";
            dtGrdVwReport.ReadOnly = true;
            dtGrdVwReport.RightToLeft = RightToLeft.Yes;
            dtGrdVwReport.Size = new Size(343, 275);
            dtGrdVwReport.TabIndex = 74;
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
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(601, 43);
            lblWarehouse.Margin = new Padding(4, 0, 4, 0);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(64, 15);
            lblWarehouse.TabIndex = 73;
            lblWarehouse.Text = "إسم المخزن";
            // 
            // cmboBxWarehouse
            // 
            cmboBxWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxWarehouse.FormattingEnabled = true;
            cmboBxWarehouse.Location = new Point(418, 39);
            cmboBxWarehouse.Margin = new Padding(4, 3, 4, 3);
            cmboBxWarehouse.Name = "cmboBxWarehouse";
            cmboBxWarehouse.Size = new Size(176, 23);
            cmboBxWarehouse.TabIndex = 72;
            // 
            // nmrcUpDwnMinDays
            // 
            nmrcUpDwnMinDays.Location = new Point(418, 77);
            nmrcUpDwnMinDays.Margin = new Padding(4, 3, 4, 3);
            nmrcUpDwnMinDays.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrcUpDwnMinDays.Name = "nmrcUpDwnMinDays";
            nmrcUpDwnMinDays.Size = new Size(176, 23);
            nmrcUpDwnMinDays.TabIndex = 80;
            // 
            // lblMinDays
            // 
            lblMinDays.AutoSize = true;
            lblMinDays.Location = new Point(601, 79);
            lblMinDays.Margin = new Padding(4, 0, 4, 0);
            lblMinDays.Name = "lblMinDays";
            lblMinDays.Size = new Size(100, 15);
            lblMinDays.TabIndex = 79;
            lblMinDays.Text = "الفترة الزمنية بالأيام";
            // 
            // FormGenerateReportProductDuration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(nmrcUpDwnMinDays);
            Controls.Add(lblMinDays);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtGrdVwReport);
            Controls.Add(lblWarehouse);
            Controls.Add(cmboBxWarehouse);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGenerateReportProductDuration";
            Text = "تقرير عن أصناف مر عليها فترة زمنية";
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnMinDays).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dtGrdVwReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmboBxWarehouse;
        private NumericUpDown nmrcUpDwnMinDays;
        private Label lblMinDays;
    }
}
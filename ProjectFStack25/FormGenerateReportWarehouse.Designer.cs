namespace ProjectFStack25
{
    partial class FormGenerateReportWarehouse
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
            lblWarehouse = new Label();
            cmboBxWarehouse = new ComboBox();
            dtTmPckrTo = new DateTimePicker();
            dtTmPckrFrom = new DateTimePicker();
            lblPeriod = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            dtGrdVwReport = new DataGridView();
            clmnCode = new DataGridViewTextBoxColumn();
            clmnName = new DataGridViewTextBoxColumn();
            clmnQuantity = new DataGridViewTextBoxColumn();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).BeginInit();
            SuspendLayout();
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(852, 37);
            lblWarehouse.Margin = new Padding(4, 0, 4, 0);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(64, 15);
            lblWarehouse.TabIndex = 64;
            lblWarehouse.Text = "إسم المخزن";
            // 
            // cmboBxWarehouse
            // 
            cmboBxWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxWarehouse.FormattingEnabled = true;
            cmboBxWarehouse.Location = new Point(668, 33);
            cmboBxWarehouse.Margin = new Padding(4, 3, 4, 3);
            cmboBxWarehouse.Name = "cmboBxWarehouse";
            cmboBxWarehouse.Size = new Size(176, 23);
            cmboBxWarehouse.TabIndex = 63;
            // 
            // dtTmPckrTo
            // 
            dtTmPckrTo.Location = new Point(168, 74);
            dtTmPckrTo.Margin = new Padding(4, 3, 4, 3);
            dtTmPckrTo.Name = "dtTmPckrTo";
            dtTmPckrTo.Size = new Size(176, 23);
            dtTmPckrTo.TabIndex = 65;
            // 
            // dtTmPckrFrom
            // 
            dtTmPckrFrom.Location = new Point(168, 33);
            dtTmPckrFrom.Margin = new Padding(4, 3, 4, 3);
            dtTmPckrFrom.Name = "dtTmPckrFrom";
            dtTmPckrFrom.Size = new Size(176, 23);
            dtTmPckrFrom.TabIndex = 66;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new Point(412, 37);
            lblPeriod.Margin = new Padding(4, 0, 4, 0);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(37, 15);
            lblPeriod.TabIndex = 67;
            lblPeriod.Text = ":الفترة";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(351, 81);
            lblTo.Margin = new Padding(4, 0, 4, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(24, 15);
            lblTo.TabIndex = 68;
            lblTo.Text = "إلى";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(351, 37);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(22, 15);
            lblFrom.TabIndex = 69;
            lblFrom.Text = "من";
            // 
            // dtGrdVwReport
            // 
            dtGrdVwReport.AllowUserToAddRows = false;
            dtGrdVwReport.AllowUserToDeleteRows = false;
            dtGrdVwReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwReport.Columns.AddRange(new DataGridViewColumn[] { clmnCode, clmnName, clmnQuantity });
            dtGrdVwReport.Location = new Point(576, 200);
            dtGrdVwReport.Margin = new Padding(4, 3, 4, 3);
            dtGrdVwReport.Name = "dtGrdVwReport";
            dtGrdVwReport.ReadOnly = true;
            dtGrdVwReport.RightToLeft = RightToLeft.Yes;
            dtGrdVwReport.Size = new Size(344, 275);
            dtGrdVwReport.TabIndex = 70;
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
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(831, 155);
            btnGenerateReport.Margin = new Padding(4, 3, 4, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(88, 27);
            btnGenerateReport.TabIndex = 71;
            btnGenerateReport.Text = "التقرير";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // FormGenerateReportWarehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtGrdVwReport);
            Controls.Add(lblFrom);
            Controls.Add(lblTo);
            Controls.Add(lblPeriod);
            Controls.Add(dtTmPckrFrom);
            Controls.Add(dtTmPckrTo);
            Controls.Add(lblWarehouse);
            Controls.Add(cmboBxWarehouse);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGenerateReportWarehouse";
            Text = "تقرير عن مخزن";
            ((System.ComponentModel.ISupportInitialize)dtGrdVwReport).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmboBxWarehouse;
        private System.Windows.Forms.DateTimePicker dtTmPckrTo;
        private System.Windows.Forms.DateTimePicker dtTmPckrFrom;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataGridView dtGrdVwReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.Button btnGenerateReport;

    }
}
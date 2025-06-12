namespace ProjectFStack25
{
    partial class FormAddTransfer
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
            this.nmrcUpDwnQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtTmPckrExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrProductionDate = new System.Windows.Forms.DateTimePicker();
            this.cmboBxCode = new System.Windows.Forms.ComboBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAddTransfer = new System.Windows.Forms.Button();
            this.cmboBxSourceWarehouse = new System.Windows.Forms.ComboBox();
            this.cmboBxDestinationWarehouse = new System.Windows.Forms.ComboBox();
            this.lblSourceWarehouse = new System.Windows.Forms.Label();
            this.lblDestinationWarehouse = new System.Windows.Forms.Label();
            this.dtTmPckrDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrcUpDwnQuantity
            // 
            this.nmrcUpDwnQuantity.Location = new System.Drawing.Point(237, 153);
            this.nmrcUpDwnQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcUpDwnQuantity.Name = "nmrcUpDwnQuantity";
            this.nmrcUpDwnQuantity.Size = new System.Drawing.Size(151, 20);
            this.nmrcUpDwnQuantity.TabIndex = 59;
            // 
            // dtTmPckrExpirationDate
            // 
            this.dtTmPckrExpirationDate.Location = new System.Drawing.Point(237, 244);
            this.dtTmPckrExpirationDate.Name = "dtTmPckrExpirationDate";
            this.dtTmPckrExpirationDate.Size = new System.Drawing.Size(151, 20);
            this.dtTmPckrExpirationDate.TabIndex = 58;
            // 
            // dtTmPckrProductionDate
            // 
            this.dtTmPckrProductionDate.Location = new System.Drawing.Point(237, 197);
            this.dtTmPckrProductionDate.Name = "dtTmPckrProductionDate";
            this.dtTmPckrProductionDate.Size = new System.Drawing.Size(151, 20);
            this.dtTmPckrProductionDate.TabIndex = 57;
            // 
            // cmboBxCode
            // 
            this.cmboBxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxCode.FormattingEnabled = true;
            this.cmboBxCode.Location = new System.Drawing.Point(237, 115);
            this.cmboBxCode.Name = "cmboBxCode";
            this.cmboBxCode.Size = new System.Drawing.Size(151, 21);
            this.cmboBxCode.TabIndex = 56;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(485, 250);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(68, 13);
            this.lblExpirationDate.TabIndex = 55;
            this.lblExpirationDate.Text = "تاريخ الإنتهاء";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(485, 203);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(64, 13);
            this.lblProductionDate.TabIndex = 54;
            this.lblProductionDate.Text = "تاريخ الإنتاج";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(485, 160);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 13);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "الكمية";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(485, 118);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 13);
            this.lblCode.TabIndex = 52;
            this.lblCode.Text = "كود الصنف";
            // 
            // btnAddTransfer
            // 
            this.btnAddTransfer.Location = new System.Drawing.Point(488, 424);
            this.btnAddTransfer.Name = "btnAddTransfer";
            this.btnAddTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransfer.TabIndex = 51;
            this.btnAddTransfer.Text = "تحويل الصنف";
            this.btnAddTransfer.UseVisualStyleBackColor = true;
            this.btnAddTransfer.Click += new System.EventHandler(this.btnAddTransfer_Click);
            // 
            // cmboBxSourceWarehouse
            // 
            this.cmboBxSourceWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxSourceWarehouse.FormattingEnabled = true;
            this.cmboBxSourceWarehouse.Location = new System.Drawing.Point(237, 335);
            this.cmboBxSourceWarehouse.Name = "cmboBxSourceWarehouse";
            this.cmboBxSourceWarehouse.Size = new System.Drawing.Size(151, 21);
            this.cmboBxSourceWarehouse.TabIndex = 60;
            // 
            // cmboBxDestinationWarehouse
            // 
            this.cmboBxDestinationWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxDestinationWarehouse.FormattingEnabled = true;
            this.cmboBxDestinationWarehouse.Location = new System.Drawing.Point(237, 383);
            this.cmboBxDestinationWarehouse.Name = "cmboBxDestinationWarehouse";
            this.cmboBxDestinationWarehouse.Size = new System.Drawing.Size(151, 21);
            this.cmboBxDestinationWarehouse.TabIndex = 61;
            // 
            // lblSourceWarehouse
            // 
            this.lblSourceWarehouse.AutoSize = true;
            this.lblSourceWarehouse.Location = new System.Drawing.Point(485, 338);
            this.lblSourceWarehouse.Name = "lblSourceWarehouse";
            this.lblSourceWarehouse.Size = new System.Drawing.Size(19, 13);
            this.lblSourceWarehouse.TabIndex = 62;
            this.lblSourceWarehouse.Text = "من";
            // 
            // lblDestinationWarehouse
            // 
            this.lblDestinationWarehouse.AutoSize = true;
            this.lblDestinationWarehouse.Location = new System.Drawing.Point(485, 386);
            this.lblDestinationWarehouse.Name = "lblDestinationWarehouse";
            this.lblDestinationWarehouse.Size = new System.Drawing.Size(24, 13);
            this.lblDestinationWarehouse.TabIndex = 63;
            this.lblDestinationWarehouse.Text = "إلى";
            // 
            // dtTmPckrDate
            // 
            this.dtTmPckrDate.Location = new System.Drawing.Point(237, 290);
            this.dtTmPckrDate.Name = "dtTmPckrDate";
            this.dtTmPckrDate.Size = new System.Drawing.Size(151, 20);
            this.dtTmPckrDate.TabIndex = 65;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(485, 296);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 13);
            this.lblDate.TabIndex = 64;
            this.lblDate.Text = "تاريخ التحويل";
            // 
            // FormAddTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.dtTmPckrDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDestinationWarehouse);
            this.Controls.Add(this.lblSourceWarehouse);
            this.Controls.Add(this.cmboBxDestinationWarehouse);
            this.Controls.Add(this.cmboBxSourceWarehouse);
            this.Controls.Add(this.nmrcUpDwnQuantity);
            this.Controls.Add(this.dtTmPckrExpirationDate);
            this.Controls.Add(this.dtTmPckrProductionDate);
            this.Controls.Add(this.cmboBxCode);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAddTransfer);
            this.Name = "FormAddTransfer";
            this.Text = "تحويل صنف من مخزن إلى مخزن";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcUpDwnQuantity;
        private System.Windows.Forms.DateTimePicker dtTmPckrExpirationDate;
        private System.Windows.Forms.DateTimePicker dtTmPckrProductionDate;
        private System.Windows.Forms.ComboBox cmboBxCode;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAddTransfer;
        private System.Windows.Forms.ComboBox cmboBxSourceWarehouse;
        private System.Windows.Forms.ComboBox cmboBxDestinationWarehouse;
        private System.Windows.Forms.Label lblSourceWarehouse;
        private System.Windows.Forms.Label lblDestinationWarehouse;
        private System.Windows.Forms.DateTimePicker dtTmPckrDate;
        private System.Windows.Forms.Label lblDate;

    }
}
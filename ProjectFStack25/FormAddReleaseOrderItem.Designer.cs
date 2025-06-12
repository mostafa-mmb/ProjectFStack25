namespace ProjectFStack25
{
    partial class FormAddReleaseOrderItem
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
            this.btnAddSupplyItem = new System.Windows.Forms.Button();
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
            // btnAddSupplyItem
            // 
            this.btnAddSupplyItem.Location = new System.Drawing.Point(488, 313);
            this.btnAddSupplyItem.Name = "btnAddSupplyItem";
            this.btnAddSupplyItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplyItem.TabIndex = 51;
            this.btnAddSupplyItem.Text = "أضف الصنف";
            this.btnAddSupplyItem.UseVisualStyleBackColor = true;
            this.btnAddSupplyItem.Click += new System.EventHandler(this.btnAddSupplyItem_Click);
            // 
            // FormAddReleaseOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmrcUpDwnQuantity);
            this.Controls.Add(this.dtTmPckrExpirationDate);
            this.Controls.Add(this.dtTmPckrProductionDate);
            this.Controls.Add(this.cmboBxCode);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAddSupplyItem);
            this.Name = "FormAddReleaseOrderItem";
            this.Text = "إضافة صنف";
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
        private System.Windows.Forms.Button btnAddSupplyItem;
    }
}
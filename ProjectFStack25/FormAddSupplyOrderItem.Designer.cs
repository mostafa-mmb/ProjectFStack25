namespace ProjectFStack25
{
    partial class FormAddSupplyOrderItem
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
            this.btnAddSupplyItem = new System.Windows.Forms.Button();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.cmboBxCode = new System.Windows.Forms.ComboBox();
            this.dtTmPckrProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.nmrcUpDwnQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSupplyItem
            // 
            this.btnAddSupplyItem.Location = new System.Drawing.Point(488, 311);
            this.btnAddSupplyItem.Name = "btnAddSupplyItem";
            this.btnAddSupplyItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplyItem.TabIndex = 34;
            this.btnAddSupplyItem.Text = "أضف الصنف";
            this.btnAddSupplyItem.UseVisualStyleBackColor = true;
            this.btnAddSupplyItem.Click += new System.EventHandler(this.btnAddSupplyItem_Click);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(485, 248);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(68, 13);
            this.lblExpirationDate.TabIndex = 42;
            this.lblExpirationDate.Text = "تاريخ الإنتهاء";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(485, 201);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(64, 13);
            this.lblProductionDate.TabIndex = 41;
            this.lblProductionDate.Text = "تاريخ الإنتاج";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(485, 158);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 13);
            this.lblQuantity.TabIndex = 40;
            this.lblQuantity.Text = "الكمية";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(485, 116);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 13);
            this.lblCode.TabIndex = 39;
            this.lblCode.Text = "كود الصنف";
            // 
            // cmboBxCode
            // 
            this.cmboBxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxCode.FormattingEnabled = true;
            this.cmboBxCode.Location = new System.Drawing.Point(237, 113);
            this.cmboBxCode.Name = "cmboBxCode";
            this.cmboBxCode.Size = new System.Drawing.Size(151, 21);
            this.cmboBxCode.TabIndex = 47;
            // 
            // dtTmPckrProductionDate
            // 
            this.dtTmPckrProductionDate.Location = new System.Drawing.Point(237, 195);
            this.dtTmPckrProductionDate.Name = "dtTmPckrProductionDate";
            this.dtTmPckrProductionDate.Size = new System.Drawing.Size(151, 20);
            this.dtTmPckrProductionDate.TabIndex = 48;
            // 
            // dtTmPckrExpirationDate
            // 
            this.dtTmPckrExpirationDate.Location = new System.Drawing.Point(237, 242);
            this.dtTmPckrExpirationDate.Name = "dtTmPckrExpirationDate";
            this.dtTmPckrExpirationDate.Size = new System.Drawing.Size(151, 20);
            this.dtTmPckrExpirationDate.TabIndex = 49;
            // 
            // nmrcUpDwnQuantity
            // 
            this.nmrcUpDwnQuantity.Location = new System.Drawing.Point(237, 151);
            this.nmrcUpDwnQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcUpDwnQuantity.Name = "nmrcUpDwnQuantity";
            this.nmrcUpDwnQuantity.Size = new System.Drawing.Size(151, 20);
            this.nmrcUpDwnQuantity.TabIndex = 50;
            // 
            // FormAddSupplyOrderItem
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
            this.Name = "FormAddSupplyOrderItem";
            this.Text = "إضافة صنف";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSupplyItem;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cmboBxCode;
        private System.Windows.Forms.DateTimePicker dtTmPckrProductionDate;
        private System.Windows.Forms.DateTimePicker dtTmPckrExpirationDate;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnQuantity;

    }
}
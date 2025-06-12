namespace ProjectFStack25
{
    partial class FormSelectWarehouse
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
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cmboBxWarehouse = new System.Windows.Forms.ComboBox();
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(450, 218);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(58, 13);
            this.lblWarehouse.TabIndex = 66;
            this.lblWarehouse.Text = "إسم المخزن";
            // 
            // cmboBxWarehouse
            // 
            this.cmboBxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxWarehouse.FormattingEnabled = true;
            this.cmboBxWarehouse.Location = new System.Drawing.Point(293, 215);
            this.cmboBxWarehouse.Name = "cmboBxWarehouse";
            this.cmboBxWarehouse.Size = new System.Drawing.Size(151, 21);
            this.cmboBxWarehouse.TabIndex = 65;
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(453, 287);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(75, 23);
            this.btnAddWarehouse.TabIndex = 67;
            this.btnAddWarehouse.Text = "أضف المخزن";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // FormSelectWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.cmboBxWarehouse);
            this.Name = "FormSelectWarehouse";
            this.Text = "اختيار مخزن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmboBxWarehouse;
        private System.Windows.Forms.Button btnAddWarehouse;

    }
}
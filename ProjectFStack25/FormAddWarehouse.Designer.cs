namespace ProjectFStack25
{
    partial class FormAddWarehouse
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
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.txtBxWarehouseAddress = new System.Windows.Forms.TextBox();
            this.txtBxWarehouseSupervisor = new System.Windows.Forms.TextBox();
            this.txtBxWarehouseName = new System.Windows.Forms.TextBox();
            this.lblWarehouseSupervisor = new System.Windows.Forms.Label();
            this.lblWarehouseAddress = new System.Windows.Forms.Label();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(439, 349);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(75, 23);
            this.btnAddWarehouse.TabIndex = 13;
            this.btnAddWarehouse.Text = "أضف المخزن";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // txtBxWarehouseAddress
            // 
            this.txtBxWarehouseAddress.Location = new System.Drawing.Point(271, 151);
            this.txtBxWarehouseAddress.Name = "txtBxWarehouseAddress";
            this.txtBxWarehouseAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBxWarehouseAddress.TabIndex = 12;
            // 
            // txtBxWarehouseSupervisor
            // 
            this.txtBxWarehouseSupervisor.Location = new System.Drawing.Point(271, 235);
            this.txtBxWarehouseSupervisor.Name = "txtBxWarehouseSupervisor";
            this.txtBxWarehouseSupervisor.Size = new System.Drawing.Size(100, 20);
            this.txtBxWarehouseSupervisor.TabIndex = 11;
            // 
            // txtBxWarehouseName
            // 
            this.txtBxWarehouseName.Location = new System.Drawing.Point(271, 80);
            this.txtBxWarehouseName.Name = "txtBxWarehouseName";
            this.txtBxWarehouseName.Size = new System.Drawing.Size(100, 20);
            this.txtBxWarehouseName.TabIndex = 10;
            // 
            // lblWarehouseSupervisor
            // 
            this.lblWarehouseSupervisor.AutoSize = true;
            this.lblWarehouseSupervisor.Location = new System.Drawing.Point(436, 238);
            this.lblWarehouseSupervisor.Name = "lblWarehouseSupervisor";
            this.lblWarehouseSupervisor.Size = new System.Drawing.Size(94, 13);
            this.lblWarehouseSupervisor.TabIndex = 9;
            this.lblWarehouseSupervisor.Text = "المسئول عن المخزن";
            // 
            // lblWarehouseAddress
            // 
            this.lblWarehouseAddress.AutoSize = true;
            this.lblWarehouseAddress.Location = new System.Drawing.Point(436, 154);
            this.lblWarehouseAddress.Name = "lblWarehouseAddress";
            this.lblWarehouseAddress.Size = new System.Drawing.Size(67, 13);
            this.lblWarehouseAddress.TabIndex = 8;
            this.lblWarehouseAddress.Text = "عنوان المخزن";
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Location = new System.Drawing.Point(436, 83);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(57, 13);
            this.lblWarehouseName.TabIndex = 7;
            this.lblWarehouseName.Text = "اسم المخزن";
            // 
            // FormAddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.txtBxWarehouseAddress);
            this.Controls.Add(this.txtBxWarehouseSupervisor);
            this.Controls.Add(this.txtBxWarehouseName);
            this.Controls.Add(this.lblWarehouseSupervisor);
            this.Controls.Add(this.lblWarehouseAddress);
            this.Controls.Add(this.lblWarehouseName);
            this.Name = "FormAddWarehouse";
            this.Text = "إضافة مخزن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.TextBox txtBxWarehouseAddress;
        private System.Windows.Forms.TextBox txtBxWarehouseSupervisor;
        private System.Windows.Forms.TextBox txtBxWarehouseName;
        private System.Windows.Forms.Label lblWarehouseSupervisor;
        private System.Windows.Forms.Label lblWarehouseAddress;
        private System.Windows.Forms.Label lblWarehouseName;

    }
}
namespace ProjectFStack25
{
    partial class FormUpdateWarehouse
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
            btnUpdateWarehouse = new Button();
            txtBxWarehouseAddress = new TextBox();
            txtBxWarehouseSupervisor = new TextBox();
            lblWarehouseSupervisor = new Label();
            lblWarehouseAddress = new Label();
            lblWarehouseName = new Label();
            cmboBxWarehouseName = new ComboBox();
            SuspendLayout();
            // 
            // btnUpdateWarehouse
            // 
            btnUpdateWarehouse.Location = new Point(512, 390);
            btnUpdateWarehouse.Margin = new Padding(4, 3, 4, 3);
            btnUpdateWarehouse.Name = "btnUpdateWarehouse";
            btnUpdateWarehouse.Size = new Size(88, 27);
            btnUpdateWarehouse.TabIndex = 19;
            btnUpdateWarehouse.Text = "عدل المخزن";
            btnUpdateWarehouse.UseVisualStyleBackColor = true;
            btnUpdateWarehouse.Click += btnUpdateWarehouse_Click;
            // 
            // txtBxWarehouseAddress
            // 
            txtBxWarehouseAddress.Location = new Point(316, 183);
            txtBxWarehouseAddress.Margin = new Padding(4, 3, 4, 3);
            txtBxWarehouseAddress.Name = "txtBxWarehouseAddress";
            txtBxWarehouseAddress.Size = new Size(116, 23);
            txtBxWarehouseAddress.TabIndex = 18;
            // 
            // txtBxWarehouseSupervisor
            // 
            txtBxWarehouseSupervisor.Location = new Point(316, 280);
            txtBxWarehouseSupervisor.Margin = new Padding(4, 3, 4, 3);
            txtBxWarehouseSupervisor.Name = "txtBxWarehouseSupervisor";
            txtBxWarehouseSupervisor.Size = new Size(116, 23);
            txtBxWarehouseSupervisor.TabIndex = 17;
            // 
            // lblWarehouseSupervisor
            // 
            lblWarehouseSupervisor.AutoSize = true;
            lblWarehouseSupervisor.Location = new Point(509, 284);
            lblWarehouseSupervisor.Margin = new Padding(4, 0, 4, 0);
            lblWarehouseSupervisor.Name = "lblWarehouseSupervisor";
            lblWarehouseSupervisor.Size = new Size(104, 15);
            lblWarehouseSupervisor.TabIndex = 15;
            lblWarehouseSupervisor.Text = "المسئول عن المخزن";
            // 
            // lblWarehouseAddress
            // 
            lblWarehouseAddress.AutoSize = true;
            lblWarehouseAddress.Location = new Point(509, 187);
            lblWarehouseAddress.Margin = new Padding(4, 0, 4, 0);
            lblWarehouseAddress.Name = "lblWarehouseAddress";
            lblWarehouseAddress.Size = new Size(72, 15);
            lblWarehouseAddress.TabIndex = 14;
            lblWarehouseAddress.Text = "عنوان المخزن";
            // 
            // lblWarehouseName
            // 
            lblWarehouseName.AutoSize = true;
            lblWarehouseName.Location = new Point(509, 105);
            lblWarehouseName.Margin = new Padding(4, 0, 4, 0);
            lblWarehouseName.Name = "lblWarehouseName";
            lblWarehouseName.Size = new Size(64, 15);
            lblWarehouseName.TabIndex = 13;
            lblWarehouseName.Text = "اسم المخزن";
            // 
            // cmboBxWarehouseName
            // 
            cmboBxWarehouseName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxWarehouseName.FormattingEnabled = true;
            cmboBxWarehouseName.Location = new Point(316, 102);
            cmboBxWarehouseName.Margin = new Padding(4, 3, 4, 3);
            cmboBxWarehouseName.Name = "cmboBxWarehouseName";
            cmboBxWarehouseName.Size = new Size(116, 23);
            cmboBxWarehouseName.TabIndex = 65;
            cmboBxWarehouseName.SelectedIndexChanged += cmboBxWarehouseName_SelectedIndexChanged;
            // 
            // FormUpdateWarehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(cmboBxWarehouseName);
            Controls.Add(btnUpdateWarehouse);
            Controls.Add(txtBxWarehouseAddress);
            Controls.Add(txtBxWarehouseSupervisor);
            Controls.Add(lblWarehouseSupervisor);
            Controls.Add(lblWarehouseAddress);
            Controls.Add(lblWarehouseName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUpdateWarehouse";
            Text = "تعديل مخزن";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateWarehouse;
        private System.Windows.Forms.TextBox txtBxWarehouseAddress;
        private System.Windows.Forms.TextBox txtBxWarehouseSupervisor;
        private System.Windows.Forms.Label lblWarehouseSupervisor;
        private System.Windows.Forms.Label lblWarehouseAddress;
        private System.Windows.Forms.Label lblWarehouseName;
        private ComboBox cmboBxWarehouseName;
    }
}
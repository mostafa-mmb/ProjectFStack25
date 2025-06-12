namespace ProjectFStack25
{
    partial class FormUpdateProduct
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
            BtnUpdateProduct = new Button();
            txtBxName = new TextBox();
            lblName = new Label();
            lblCode = new Label();
            cmboBxProductCode = new ComboBox();
            SuspendLayout();
            // 
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Location = new Point(569, 314);
            BtnUpdateProduct.Margin = new Padding(4, 3, 4, 3);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(88, 27);
            BtnUpdateProduct.TabIndex = 40;
            BtnUpdateProduct.Text = "عدل الصنف";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(276, 233);
            txtBxName.Margin = new Padding(4, 3, 4, 3);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(176, 23);
            txtBxName.TabIndex = 39;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(566, 237);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 15);
            lblName.TabIndex = 37;
            lblName.Text = "إسم الصنف";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(566, 182);
            lblCode.Margin = new Padding(4, 0, 4, 0);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(63, 15);
            lblCode.TabIndex = 36;
            lblCode.Text = "كود الصنف";
            // 
            // cmboBxProductCode
            // 
            cmboBxProductCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxProductCode.FormattingEnabled = true;
            cmboBxProductCode.Location = new Point(276, 179);
            cmboBxProductCode.Margin = new Padding(4, 3, 4, 3);
            cmboBxProductCode.Name = "cmboBxProductCode";
            cmboBxProductCode.Size = new Size(176, 23);
            cmboBxProductCode.TabIndex = 65;
            cmboBxProductCode.SelectedIndexChanged += cmboBxProductCode_SelectedIndexChanged;
            // 
            // FormUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(cmboBxProductCode);
            Controls.Add(BtnUpdateProduct);
            Controls.Add(txtBxName);
            Controls.Add(lblName);
            Controls.Add(lblCode);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUpdateProduct";
            Text = "تعديل صنف";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private ComboBox cmboBxProductCode;
    }
}
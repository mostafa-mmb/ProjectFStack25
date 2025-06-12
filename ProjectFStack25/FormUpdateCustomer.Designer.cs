namespace ProjectFStack25
{
    partial class FormUpdateCustomer
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
            BtnUpdateCustomer = new Button();
            txtBxWebSite = new TextBox();
            txtBxEmail = new TextBox();
            txtBxMobile = new TextBox();
            txtBxFax = new TextBox();
            txtBxPhone = new TextBox();
            lblWebsite = new Label();
            lblEmail = new Label();
            lblMobile = new Label();
            lblFax = new Label();
            lblPhone = new Label();
            lblName = new Label();
            cmboBxCustomerName = new ComboBox();
            SuspendLayout();
            // 
            // BtnUpdateCustomer
            // 
            BtnUpdateCustomer.Location = new Point(569, 405);
            BtnUpdateCustomer.Margin = new Padding(4, 3, 4, 3);
            BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            BtnUpdateCustomer.Size = new Size(88, 27);
            BtnUpdateCustomer.TabIndex = 51;
            BtnUpdateCustomer.Text = "عدل العميل";
            BtnUpdateCustomer.UseVisualStyleBackColor = true;
            BtnUpdateCustomer.Click += BtnUpdateCustomer_Click;
            // 
            // txtBxWebSite
            // 
            txtBxWebSite.Location = new Point(276, 324);
            txtBxWebSite.Margin = new Padding(4, 3, 4, 3);
            txtBxWebSite.Name = "txtBxWebSite";
            txtBxWebSite.Size = new Size(176, 23);
            txtBxWebSite.TabIndex = 50;
            // 
            // txtBxEmail
            // 
            txtBxEmail.Location = new Point(276, 270);
            txtBxEmail.Margin = new Padding(4, 3, 4, 3);
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(176, 23);
            txtBxEmail.TabIndex = 49;
            // 
            // txtBxMobile
            // 
            txtBxMobile.Location = new Point(276, 220);
            txtBxMobile.Margin = new Padding(4, 3, 4, 3);
            txtBxMobile.Name = "txtBxMobile";
            txtBxMobile.Size = new Size(176, 23);
            txtBxMobile.TabIndex = 48;
            // 
            // txtBxFax
            // 
            txtBxFax.Location = new Point(276, 172);
            txtBxFax.Margin = new Padding(4, 3, 4, 3);
            txtBxFax.Name = "txtBxFax";
            txtBxFax.Size = new Size(176, 23);
            txtBxFax.TabIndex = 47;
            // 
            // txtBxPhone
            // 
            txtBxPhone.Location = new Point(276, 127);
            txtBxPhone.Margin = new Padding(4, 3, 4, 3);
            txtBxPhone.Name = "txtBxPhone";
            txtBxPhone.Size = new Size(176, 23);
            txtBxPhone.TabIndex = 46;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(566, 328);
            lblWebsite.Margin = new Padding(4, 0, 4, 0);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(77, 15);
            lblWebsite.TabIndex = 44;
            lblWebsite.Text = "موقع الكترونى";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(566, 273);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(26, 15);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "ميل";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(566, 224);
            lblMobile.Margin = new Padding(4, 0, 4, 0);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(42, 15);
            lblMobile.TabIndex = 42;
            lblMobile.Text = "محمول";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(566, 175);
            lblFax.Margin = new Padding(4, 0, 4, 0);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(36, 15);
            lblFax.TabIndex = 41;
            lblFax.Text = "فاكس";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(566, 130);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(39, 15);
            lblPhone.TabIndex = 40;
            lblPhone.Text = "تليفون";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(566, 91);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 15);
            lblName.TabIndex = 39;
            lblName.Text = "إسم العميل";
            // 
            // cmboBxCustomerName
            // 
            cmboBxCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBxCustomerName.FormattingEnabled = true;
            cmboBxCustomerName.Location = new Point(276, 88);
            cmboBxCustomerName.Margin = new Padding(4, 3, 4, 3);
            cmboBxCustomerName.Name = "cmboBxCustomerName";
            cmboBxCustomerName.Size = new Size(176, 23);
            cmboBxCustomerName.TabIndex = 64;
            cmboBxCustomerName.SelectedIndexChanged += cmboBxCustomerName_SelectedIndexChanged;
            // 
            // FormUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(cmboBxCustomerName);
            Controls.Add(BtnUpdateCustomer);
            Controls.Add(txtBxWebSite);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxMobile);
            Controls.Add(txtBxFax);
            Controls.Add(txtBxPhone);
            Controls.Add(lblWebsite);
            Controls.Add(lblEmail);
            Controls.Add(lblMobile);
            Controls.Add(lblFax);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUpdateCustomer";
            Text = "تعديل عميل";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateCustomer;
        private System.Windows.Forms.TextBox txtBxWebSite;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxMobile;
        private System.Windows.Forms.TextBox txtBxFax;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private ComboBox cmboBxCustomerName;
    }
}
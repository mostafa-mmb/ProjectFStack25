namespace ProjectFStack25
{
    partial class FormAddSupplier
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
            this.BtnAddSupplier = new System.Windows.Forms.Button();
            this.txtBxWebSite = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxMobile = new System.Windows.Forms.TextBox();
            this.txtBxFax = new System.Windows.Forms.TextBox();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddSupplier
            // 
            this.BtnAddSupplier.Location = new System.Drawing.Point(488, 351);
            this.BtnAddSupplier.Name = "BtnAddSupplier";
            this.BtnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.BtnAddSupplier.TabIndex = 25;
            this.BtnAddSupplier.Text = "أضف مورد";
            this.BtnAddSupplier.UseVisualStyleBackColor = true;
            this.BtnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // txtBxWebSite
            // 
            this.txtBxWebSite.Location = new System.Drawing.Point(237, 281);
            this.txtBxWebSite.Name = "txtBxWebSite";
            this.txtBxWebSite.Size = new System.Drawing.Size(151, 20);
            this.txtBxWebSite.TabIndex = 24;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(237, 234);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(151, 20);
            this.txtBxEmail.TabIndex = 23;
            // 
            // txtBxMobile
            // 
            this.txtBxMobile.Location = new System.Drawing.Point(237, 191);
            this.txtBxMobile.Name = "txtBxMobile";
            this.txtBxMobile.Size = new System.Drawing.Size(151, 20);
            this.txtBxMobile.TabIndex = 22;
            // 
            // txtBxFax
            // 
            this.txtBxFax.Location = new System.Drawing.Point(237, 149);
            this.txtBxFax.Name = "txtBxFax";
            this.txtBxFax.Size = new System.Drawing.Size(151, 20);
            this.txtBxFax.TabIndex = 21;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(237, 110);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(151, 20);
            this.txtBxPhone.TabIndex = 20;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(237, 76);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(151, 20);
            this.txtBxName.TabIndex = 19;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(485, 284);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(76, 13);
            this.lblWebsite.TabIndex = 18;
            this.lblWebsite.Text = "موقع الكترونى";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(485, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(23, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "ميل";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(485, 194);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(37, 13);
            this.lblMobile.TabIndex = 16;
            this.lblMobile.Text = "محمول";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(485, 152);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(33, 13);
            this.lblFax.TabIndex = 15;
            this.lblFax.Text = "فاكس";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(485, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(36, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "تليفون";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(485, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "إسم المورد";
            // 
            // FormAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddSupplier);
            this.Controls.Add(this.txtBxWebSite);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxMobile);
            this.Controls.Add(this.txtBxFax);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "FormAddSupplier";
            this.Text = "إضافة مورد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddSupplier;
        private System.Windows.Forms.TextBox txtBxWebSite;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxMobile;
        private System.Windows.Forms.TextBox txtBxFax;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;

    }
}
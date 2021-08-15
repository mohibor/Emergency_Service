
namespace EmergencyService
{
    partial class Login
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
            this.lblNIDNo = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lnkLblSignUp = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkForgotpassword = new System.Windows.Forms.LinkLabel();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNIDNo
            // 
            this.lblNIDNo.AutoSize = true;
            this.lblNIDNo.Location = new System.Drawing.Point(130, 148);
            this.lblNIDNo.Name = "lblNIDNo";
            this.lblNIDNo.Size = new System.Drawing.Size(66, 13);
            this.lblNIDNo.TabIndex = 0;
            this.lblNIDNo.Text = "NID Number";
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(207, 145);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(100, 20);
            this.txtNID.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(130, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(191, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Location = new System.Drawing.Point(125, 291);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(122, 13);
            this.lblSignUp.TabIndex = 5;
            this.lblSignUp.Text = "Don\'t have an account?";
            // 
            // lnkLblSignUp
            // 
            this.lnkLblSignUp.AutoSize = true;
            this.lnkLblSignUp.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblSignUp.Location = new System.Drawing.Point(257, 291);
            this.lnkLblSignUp.Name = "lnkLblSignUp";
            this.lnkLblSignUp.Size = new System.Drawing.Size(45, 13);
            this.lnkLblSignUp.TabIndex = 6;
            this.lnkLblSignUp.TabStop = true;
            this.lnkLblSignUp.Text = "Sign Up";
            this.lnkLblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblSignUp_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(116, 89);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 25);
            this.lblHeader.TabIndex = 34;
            this.lblHeader.Text = "Emergency Service";
            // 
            // lnkForgotpassword
            // 
            this.lnkForgotpassword.AutoSize = true;
            this.lnkForgotpassword.LinkColor = System.Drawing.Color.Aqua;
            this.lnkForgotpassword.Location = new System.Drawing.Point(171, 332);
            this.lnkForgotpassword.Name = "lnkForgotpassword";
            this.lnkForgotpassword.Size = new System.Drawing.Size(95, 13);
            this.lnkForgotpassword.TabIndex = 35;
            this.lnkForgotpassword.TabStop = true;
            this.lnkForgotpassword.Text = "Forgot Password? ";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(130, 225);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(0, 13);
            this.lblErrorText.TabIndex = 36;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lnkForgotpassword);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lnkLblSignUp);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.lblNIDNo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIDNo;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.LinkLabel lnkLblSignUp;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkForgotpassword;
        private System.Windows.Forms.Label lblErrorText;
    }
}


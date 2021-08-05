
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lnkLblSignUp = new System.Windows.Forms.LinkLabel();
            this.chckBoxKeepLogin = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkForgotpassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(130, 148);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(207, 145);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
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
            this.btnLogin.Location = new System.Drawing.Point(196, 264);
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
            this.lblSignUp.Location = new System.Drawing.Point(130, 304);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(122, 13);
            this.lblSignUp.TabIndex = 5;
            this.lblSignUp.Text = "Don\'t have an account?";
            // 
            // lnkLblSignUp
            // 
            this.lnkLblSignUp.AutoSize = true;
            this.lnkLblSignUp.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblSignUp.Location = new System.Drawing.Point(262, 304);
            this.lnkLblSignUp.Name = "lnkLblSignUp";
            this.lnkLblSignUp.Size = new System.Drawing.Size(45, 13);
            this.lnkLblSignUp.TabIndex = 6;
            this.lnkLblSignUp.TabStop = true;
            this.lnkLblSignUp.Text = "Sign Up";
            this.lnkLblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblSignUp_LinkClicked);
            // 
            // chckBoxKeepLogin
            // 
            this.chckBoxKeepLogin.AutoSize = true;
            this.chckBoxKeepLogin.Location = new System.Drawing.Point(133, 231);
            this.chckBoxKeepLogin.Name = "chckBoxKeepLogin";
            this.chckBoxKeepLogin.Size = new System.Drawing.Size(114, 17);
            this.chckBoxKeepLogin.TabIndex = 18;
            this.chckBoxKeepLogin.Text = "Keep me logged in";
            this.chckBoxKeepLogin.UseVisualStyleBackColor = true;
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
            this.lnkForgotpassword.Location = new System.Drawing.Point(176, 345);
            this.lnkForgotpassword.Name = "lnkForgotpassword";
            this.lnkForgotpassword.Size = new System.Drawing.Size(95, 13);
            this.lnkForgotpassword.TabIndex = 35;
            this.lnkForgotpassword.TabStop = true;
            this.lnkForgotpassword.Text = "Forgot Password? ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.lnkForgotpassword);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.chckBoxKeepLogin);
            this.Controls.Add(this.lnkLblSignUp);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.LinkLabel lnkLblSignUp;
        private System.Windows.Forms.CheckBox chckBoxKeepLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkForgotpassword;
    }
}


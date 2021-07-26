
namespace EmergencyService
{
    partial class SignUp
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
            this.lnkLblLogin = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.chckBoxTermsAndCondition = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lnkLblLogin
            // 
            this.lnkLblLogin.AutoSize = true;
            this.lnkLblLogin.Location = new System.Drawing.Point(215, 403);
            this.lnkLblLogin.Name = "lnkLblLogin";
            this.lnkLblLogin.Size = new System.Drawing.Size(76, 13);
            this.lnkLblLogin.TabIndex = 0;
            this.lnkLblLogin.TabStop = true;
            this.lnkLblLogin.Text = "Back to Login ";
            this.lnkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogin_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(45, 105);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Location = new System.Drawing.Point(45, 151);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(43, 13);
            this.lblNID.TabIndex = 3;
            this.lblNID.Text = "NID No";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(45, 196);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(45, 286);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(155, 102);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(44, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(155, 148);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(280, 20);
            this.txtNID.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(155, 193);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 240);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(155, 283);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(280, 20);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(218, 365);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(249, 105);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Location = new System.Drawing.Point(309, 103);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(48, 17);
            this.rdBtnMale.TabIndex = 15;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "Male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Location = new System.Drawing.Point(363, 103);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdBtnFemale.TabIndex = 16;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // chckBoxTermsAndCondition
            // 
            this.chckBoxTermsAndCondition.AutoSize = true;
            this.chckBoxTermsAndCondition.Location = new System.Drawing.Point(53, 329);
            this.chckBoxTermsAndCondition.Name = "chckBoxTermsAndCondition";
            this.chckBoxTermsAndCondition.Size = new System.Drawing.Size(123, 17);
            this.chckBoxTermsAndCondition.TabIndex = 17;
            this.chckBoxTermsAndCondition.Text = "Terms and Condition";
            this.chckBoxTermsAndCondition.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.chckBoxTermsAndCondition);
            this.Controls.Add(this.rdBtnFemale);
            this.Controls.Add(this.rdBtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkLblLogin);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLblLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdBtnMale;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.CheckBox chckBoxTermsAndCondition;
    }
}

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
            this.lblNID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.chckBoxTermsAndCondition = new System.Windows.Forms.CheckBox();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.dTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmergencyPhone = new System.Windows.Forms.Label();
            this.txtEmergencyPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnkLblTermsAndConditions = new System.Windows.Forms.LinkLabel();
            this.cmbBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.lbl88_1 = new System.Windows.Forms.Label();
            this.lbl88_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkLblLogin
            // 
            this.lnkLblLogin.AutoSize = true;
            this.lnkLblLogin.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblLogin.Location = new System.Drawing.Point(196, 434);
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
            this.lblName.Location = new System.Drawing.Point(27, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Location = new System.Drawing.Point(26, 209);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(43, 13);
            this.lblNID.TabIndex = 3;
            this.lblNID.Text = "NID No";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(25, 292);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(135, 209);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(280, 20);
            this.txtNID.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 262);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(135, 289);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(280, 20);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Location = new System.Drawing.Point(197, 388);
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
            this.lblGender.Location = new System.Drawing.Point(305, 185);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // chckBoxTermsAndCondition
            // 
            this.chckBoxTermsAndCondition.AutoSize = true;
            this.chckBoxTermsAndCondition.Location = new System.Drawing.Point(28, 327);
            this.chckBoxTermsAndCondition.Name = "chckBoxTermsAndCondition";
            this.chckBoxTermsAndCondition.Size = new System.Drawing.Size(15, 14);
            this.chckBoxTermsAndCondition.TabIndex = 17;
            this.chckBoxTermsAndCondition.UseVisualStyleBackColor = true;
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbBoxGender.Location = new System.Drawing.Point(353, 182);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(62, 21);
            this.cmbBoxGender.TabIndex = 18;
            // 
            // dTPDateOfBirth
            // 
            this.dTPDateOfBirth.Location = new System.Drawing.Point(135, 102);
            this.dTPDateOfBirth.Name = "dTPDateOfBirth";
            this.dTPDateOfBirth.Size = new System.Drawing.Size(198, 20);
            this.dTPDateOfBirth.TabIndex = 19;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(26, 102);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 20;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(26, 185);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblBloodGroup.TabIndex = 23;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(161, 128);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.txtPhoneNumber.TabIndex = 27;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 28;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmergencyPhone
            // 
            this.lblEmergencyPhone.AutoSize = true;
            this.lblEmergencyPhone.Location = new System.Drawing.Point(25, 157);
            this.lblEmergencyPhone.Name = "lblEmergencyPhone";
            this.lblEmergencyPhone.Size = new System.Drawing.Size(94, 13);
            this.lblEmergencyPhone.TabIndex = 29;
            this.lblEmergencyPhone.Text = "Emergency Phone";
            // 
            // txtEmergencyPhone
            // 
            this.txtEmergencyPhone.Location = new System.Drawing.Point(161, 154);
            this.txtEmergencyPhone.Name = "txtEmergencyPhone";
            this.txtEmergencyPhone.Size = new System.Drawing.Size(111, 20);
            this.txtEmergencyPhone.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Address";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(118, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 25);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Text = "Emergency Service";
            // 
            // lnkLblTermsAndConditions
            // 
            this.lnkLblTermsAndConditions.AutoSize = true;
            this.lnkLblTermsAndConditions.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblTermsAndConditions.Location = new System.Drawing.Point(49, 327);
            this.lnkLblTermsAndConditions.Name = "lnkLblTermsAndConditions";
            this.lnkLblTermsAndConditions.Size = new System.Drawing.Size(109, 13);
            this.lnkLblTermsAndConditions.TabIndex = 35;
            this.lnkLblTermsAndConditions.TabStop = true;
            this.lnkLblTermsAndConditions.Text = "Terms and Conditions";
            this.lnkLblTermsAndConditions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblTermsAndConditions_LinkClicked);
            // 
            // cmbBoxBloodGroup
            // 
            this.cmbBoxBloodGroup.FormattingEnabled = true;
            this.cmbBoxBloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cmbBoxBloodGroup.Location = new System.Drawing.Point(135, 182);
            this.cmbBoxBloodGroup.Name = "cmbBoxBloodGroup";
            this.cmbBoxBloodGroup.Size = new System.Drawing.Size(62, 21);
            this.cmbBoxBloodGroup.TabIndex = 24;
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(27, 361);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(0, 13);
            this.lblErrorText.TabIndex = 36;
            // 
            // lbl88_1
            // 
            this.lbl88_1.AutoSize = true;
            this.lbl88_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl88_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl88_1.Location = new System.Drawing.Point(132, 131);
            this.lbl88_1.Name = "lbl88_1";
            this.lbl88_1.Size = new System.Drawing.Size(25, 13);
            this.lbl88_1.TabIndex = 37;
            this.lbl88_1.Text = "+88";
            // 
            // lbl88_2
            // 
            this.lbl88_2.AutoSize = true;
            this.lbl88_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl88_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl88_2.Location = new System.Drawing.Point(132, 157);
            this.lbl88_2.Name = "lbl88_2";
            this.lbl88_2.Size = new System.Drawing.Size(25, 13);
            this.lbl88_2.TabIndex = 38;
            this.lbl88_2.Text = "+88";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.lbl88_2);
            this.Controls.Add(this.lbl88_1);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lnkLblTermsAndConditions);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmergencyPhone);
            this.Controls.Add(this.lblEmergencyPhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cmbBoxBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dTPDateOfBirth);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.chckBoxTermsAndCondition);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkLblLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLblLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chckBoxTermsAndCondition;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.DateTimePicker dTPDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.TextBox txtEmergencyPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnkLblTermsAndConditions;
        private System.Windows.Forms.ComboBox cmbBoxBloodGroup;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Label lbl88_1;
        private System.Windows.Forms.Label lbl88_2;
    }
}
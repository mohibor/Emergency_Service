using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.Data.SqlClient;

namespace EmergencyService
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection connection = Database.GetConnection();

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void lnkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private bool _IsNIDValid()
        {
            return (txtNID.Text.Trim().Length != 0 && Regex.IsMatch(txtNID.Text.Trim(), @"^(?!0)(([0-9]{10,13}))$"));
        }

        private bool _IsPhoneValid(string num)
        {
            return (num.Length != 0 && Regex.IsMatch(num, @"^(((\+8801)|(01))[3-9]\d{1}[0-9]\d{6})$"));
        }
        private bool _IsNameValid()
        {
            string name = txtName.Text.Trim();

            return (name.Length != 0 && name.Length>=2 && name.Length<=50);
        }

        private bool _IsDOBValid()
        {   
            System.TimeSpan ts = new TimeSpan(DateTime.Today.Ticks - dTPDateOfBirth.Value.Ticks);
            int age = (int)(ts.Days / 365);

            return (age>18 && age<100);
        }

        private bool _IsPasswordValid()
        {
            string password = txtPassword.Text.Trim();
            return (password.Length != 0 && password.Length > 7 && Regex.IsMatch(password, @"[!@#$%]+") && this._IsConfirmPasswordValid() && password.Length <= 50);
        }

        private bool _IsConfirmPasswordValid()
        {
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            return (confirmPassword.Length != 0 && confirmPassword.Equals(password));
        }

        private bool checkValidation(string num, string eNum)
        {
            int invalid = 0;

            if (!_IsNameValid())
            {
                lblErrorText.Text += "Invalid Name\n";
                invalid++;
            }
            if (!_IsNIDValid())
            {
                lblErrorText.Text += "Invalid NID Number\n";
                invalid++;
            }
            if(!_IsPhoneValid(num))
            {
                lblErrorText.Text += "Invalid Phone Number\n";
                invalid++;
            }
            if (!_IsPhoneValid(eNum))
            {
                lblErrorText.Text += "Invalid Emergency Phone Number\n";
                invalid++;
            }
            if (!_IsPasswordValid())
            {
                lblErrorText.Text += "Invalid Password\n";
                invalid++;
            }
            if (!_IsConfirmPasswordValid())
            {
                lblErrorText.Text += "Passowrds didn't Match\n";
                invalid++;
            }
            if (!_IsDOBValid())
            {
                lblErrorText.Text += "Invalid Date of Birth\n";
                invalid++;
            }

            if (cmbBoxBloodGroup.Text.Length == 0)
            {
                lblErrorText.Text += "Invalid Blood Group\n";
                invalid++;
            }

            if (cmbBoxGender.Text.Length == 0)
            {
                lblErrorText.Text += "Invalid Blood Group\n";
                invalid++;
            }

            if (txtAddress.Text.Length == 0)
            {
                lblErrorText.Text += "Invalid Blood Group\n";
                invalid++;
            }

            if (invalid == 0)
            {
                return true;
            }

            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string dob = dTPDateOfBirth.Value.Date.ToString().Substring(0, 10);
            string phone = "+88" + txtPhoneNumber.Text.Trim();
            string ephone = "+88" + txtEmergencyPhone.Text.Trim();
            string blood = cmbBoxBloodGroup.Text.Trim();
            string nid = txtNID.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string cpassword = txtConfirmPassword.Text.Trim();

            string query = "";
            int numberOfRowsAffect = 0;


            if (checkValidation(phone, ephone) == true)
            {
                connection.Open();

                query = String.Format("SELECT * FROM _user WHERE nid = '{0}'", nid);

                SqlCommand check = new SqlCommand(query, connection);
                numberOfRowsAffect = check.ExecuteNonQuery();

                if (numberOfRowsAffect == 0)
                {
                    if (chckBoxTermsAndCondition.Checked)
                    {
                        try
                        {
                            query = String.Format("INSERT INTO _user VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", nid, name, password, dob, phone, ephone, address, blood);
                            SqlCommand cmd1 = new SqlCommand(query, connection);
                            numberOfRowsAffect = cmd1.ExecuteNonQuery();

                            if (numberOfRowsAffect > 0)
                            {
                                connection.Close();
                                MessageBox.Show("Registration Successful");
                                new Login().Show();
                                this.Hide();
                            }
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Invalid Inputs");
                        }
                    }
                    else
                        lblErrorText.Text += "You need to accept Terms & Conditions\n";

                }
                else
                    lblErrorText.Text += "This NID Number already is Registered\n";


                connection.Close();
            }
            else
                return;
        }

        private void lnkLblTermsAndConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Terms and Conditions");
        }
    }
}

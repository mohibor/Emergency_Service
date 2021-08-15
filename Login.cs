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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private bool _IsNIDValid()
        {
            return (txtNID.Text.Trim().Length != 0 && Regex.IsMatch(txtNID.Text.Trim(), @"^(?!0)(([0-9]{10,13}))$"));
        }

        private bool _IsPasswordValid()
        {
            string password = txtPassword.Text.Trim();
            return (password.Length != 0 && password.Length > 7 && Regex.IsMatch(password, @"[!@#$%]+") && password.Length <= 50);
        }

        private bool checkValidation()
        {
            int invalid = 0;

            if (!_IsNIDValid())
            {
                lblErrorText.Text = "Invalid Credential";
                invalid++;
            }
            if (!_IsPasswordValid())
            {
                lblErrorText.Text = "Invalid Credential";
                invalid++;
            }

            if (invalid == 0)
            {
                return true;
            }

            return false;
        }

        private static SqlConnection connection = Database.GetConnection();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nid = txtNID.Text.Trim();
            string password = txtPassword.Text.Trim();
            SqlDataReader reader = null;
            int r = 0;

            connection.Open();

            try
            {
                SqlCommand cmd1 = new SqlCommand(String.Format("SELECT * FROM _admin WHERE nid='{0}' and password='{1}'", nid, password), connection);
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    r++;
                }
                if (r > 0)
                {
                    connection.Close();

                    new AdminPage().Show();
                    this.Hide();
                    return;
                }
                else 
                {
                    lblErrorText.Text = "Invalid Credentials";
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Invalid Inputs");
            }

            connection.Close();
            connection.Open();

            r = 0;

            try
            {
                SqlCommand cmd2 = new SqlCommand(String.Format("SELECT * FROM _user WHERE nid='{0}' and password='{1}'", nid, password), connection);
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    r++;
                }
                if (r > 0)
                {
                    connection.Close();

                    new Home().Show();
                    this.Hide();
                    return;
                }
                else
                {
                    lblErrorText.Text = "Invalid Credentials";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Invalid Inputs");
            }

            connection.Close();
        }

        private void lnkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}

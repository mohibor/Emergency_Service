using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EmergencyService
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "user1234")
            {
                if (password == "password")
                {
                    new MainForm().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or Password is incorrect");
            }
            else if (username == "admin")
            {
                if (password == "password")
                {
                    new AdminPage().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or Password is incorrect");
            }
            else
                MessageBox.Show("Username or Password is incorrect");
        }

        private void lnkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}

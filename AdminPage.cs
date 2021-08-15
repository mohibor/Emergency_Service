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
    public partial class AdminPage : Form
    {
        public AdminPage()
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

        private static SqlConnection connection = Database.GetConnection();

        private bool _IsNIDValid(string txt)
        {
            return (txt.Length != 0 && Regex.IsMatch(txt, @"^(?!0)(([0-9]{10,13}))$"));
        }

        private bool _IsPhoneValid(string txt)
        {
            return (txt.Length != 0 && Regex.IsMatch(txt, @"^(((\+8801)|(01))[3-9]\d{1}[0-9]\d{6})$"));
        }

        private bool _IsNameValid(string txt)
        {
            return (txt.Length != 0 && txt.Length<=50);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txt = txtSearchBox.Text.Trim();
            string option = cmbBoxSearch.Text.Trim();

            string query = "";
            int result = 0;

            if (option.Length == 0 || txt.Length == 0)
                return;

            switch (option)
            {
                case "NID Number":
                    connection.Open();


                    query = String.Format("DELETE FROM _user WHERE nid='{0}'", txt);
                    
                    SqlCommand cmd = new SqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Delete Successful");
                    else
                        MessageBox.Show("Delete Unsuccessful");

                    connection.Close();
                    break;

                default:
                    MessageBox.Show("Valid NID number of an user is Required ");
                    break;
            }
        }

        private void lnkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearchBox.Text.Trim();
            string option = cmbBoxSearch.Text.Trim();

            string query = "";

            if (option.Length == 0 || txt.Length == 0)
                return;


            if(_IsNIDValid(txt) || _IsNameValid(txt) || _IsPhoneValid(txt))
            {

            }
            if (option.Length == 0 || txt.Length == 0)
                        return;

            switch (option)
            {
                case "NID Number":
                    if (_IsNIDValid(txt))
                    {
                        query = String.Format("SELECT * FROM _user WHERE nid = '{0}'", txt);
                        new ShowPanel(query).Show();
                        this.Hide();
                    }
                    break;

                case "Phone Number":
                    if (_IsPhoneValid(txt))
                    {
                        query = String.Format("SELECT * FROM _user WHERE phone = '{0}'", txt);
                        new ShowPanel(query).Show();
                        this.Hide();
                    }
                    break;

                case "Name":
                    if (_IsNameValid(txt))
                    {
                        query = String.Format("SELECT * FROM _user WHERE name LIKE = '*{0}*'", txt);
                        new ShowPanel(query).Show();
                        this.Hide();
                    }
                    break;
            }

        }

        private void btnShowAllUser_Click(object sender, EventArgs e)
        {
            string query = String.Format("SELECT * FROM _user");

            new ShowPanel(query).Show();
            this.Hide();
        }
    }
}

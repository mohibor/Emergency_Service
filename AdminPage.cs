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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private static SqlConnection connection = Database.GetConnection();

        private void btnShow_Click(object sender, EventArgs e)
        {
            new ShowPanel().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            string temp = txtSearchBox.Text.Trim();

            string query = "";
            int result = 0;

            query = String.Format("DELETE FROM [user] WHERE id='{0}'", temp);
            SqlCommand cmd = new SqlCommand(query, connection);
            result = cmd.ExecuteNonQuery();
            
            if (result > 0)
                MessageBox.Show("Delete Successful");
            
            connection.Close();
        }

        private void lnkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

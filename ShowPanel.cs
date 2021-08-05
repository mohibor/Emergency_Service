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
    public partial class ShowPanel : Form
    {
        public ShowPanel()
        {
            InitializeComponent();
        }

        private static SqlConnection connection = Database.GetConnection();

        private void dGVShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();

            string query = String.Format("SELECT * FROM [user]");
            SqlDataAdapter dtAdapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            dtAdapter.Fill(dt);
            dGVShow.DataSource = dt;

            connection.Close();
        }

        private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }
    }
}

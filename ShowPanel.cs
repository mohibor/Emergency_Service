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

        private string query;

        public ShowPanel(string query)
        {
            InitializeComponent();
            this.query = query;
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

        private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }

        private void ShowPanel_Load(object sender, EventArgs e)
        {
            ShowPanel.connection.Open();

            SqlDataAdapter sdt = new SqlDataAdapter(this.query, ShowPanel.connection);

            DataTable dt = new DataTable();
            try
            {
                sdt.Fill(dt);
            }
            catch(Exception er)
            {
                
            }
            dGVShow.DataSource = dt;

            ShowPanel.connection.Close();
        }
    }
}

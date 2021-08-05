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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnFireService_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling Fire Service");
        }

        private void btnPolice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling Police Station");
        }

        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling Ambulance");
        }

        private void lnkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}

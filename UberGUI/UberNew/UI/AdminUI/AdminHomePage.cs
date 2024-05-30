using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.DL;
using UberNew.UI.AdminUI;
using Drivo;

namespace UberNew.UI
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }
        public void LoadForm(Form Form)
        {
            homepgpnl.Controls.Clear();
            Form f = Form as Form;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.homepgpnl.Controls.Add(f);
            this.homepgpnl.Tag = f;
            f.Show();

        }
        private void driverrequestsbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new PendingDrivers());
        }

        private void homepgpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewAllRiders() );
        }

        private void alldriversbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewAllDrivers());
        }

        private void mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}

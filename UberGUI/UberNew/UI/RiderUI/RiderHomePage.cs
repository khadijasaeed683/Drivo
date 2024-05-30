using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.UI.RiderUI;
using Drivo;

namespace UberNew.UI
{
    public partial class RiderHomePage : Form
    {
        private Rider rider;
        internal RiderHomePage(Rider r)
        {
            InitializeComponent();
            rider = r;
        }

        public void LoadForm(Form Form)
        {
            homepgpnl.Controls.Clear();
            Form f=Form as Form;
           
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.homepgpnl.Controls.Add(f);
            this.homepgpnl.Tag = f;
            f.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RiderHomePage_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookRide br = new BookRide(rider);
            br.Show();
        }

        private void homepgpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new BookRide(rider));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadForm(new ActiveRide(rider));
        }

        private void sidepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadForm(new RiderRideHistory(rider));
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            LoadForm(new BookRide(rider));

        }

        private void editinfobtn_Click(object sender, EventArgs e)
        {
            LoadForm(new RiderEditInfo(rider));
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderHomePage rhp=new RiderHomePage(rider);
            rhp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DriveBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            LoadForm(new RiderNotifications(rider));
        }
    }
}

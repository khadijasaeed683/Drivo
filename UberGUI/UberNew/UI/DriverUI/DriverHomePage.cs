using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.UI.DriverUI;
using Drivo;

namespace UberNew.UI
{
    public partial class DriverHomePage : Form
    {
        Driver driver;
        internal DriverHomePage(Driver r)
        {
            InitializeComponent();
            driver = r;
        }
        public void LoadForm(Form Form)
        {
            if(this.mainpnl.Controls.Count > 0)
            {
                this.mainpnl.Controls.RemoveAt(0);
            }
            Form f=Form as Form;
        //    Form f = (Form)Activator.CreateInstance(Form.GetType());
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpnl.Controls.Add(f);
            this.mainpnl.Tag= f;
            f.Show();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ridesbtn_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewRides(driver));  
          //  List <Trip> trips = new List <Trip>();  */
        }

        private void componentspnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editinfobtn_Click(object sender, EventArgs e)
        {
            LoadForm(new EditInfoDriver( driver));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadForm(new ActiveRideDriver( driver));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadForm(new EditInfoDriver(driver));

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

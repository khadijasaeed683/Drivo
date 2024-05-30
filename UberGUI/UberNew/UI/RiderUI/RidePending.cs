using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drivo;

namespace UberNew.UI
{
    public partial class RidePending : Form
    {
        private Rider rider;
        internal RidePending(Rider rider)
        {
            InitializeComponent();
            this.rider = rider;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form parentfrom = this.FindForm();
            if (parentfrom != null)
            {
                ParentForm.Hide();
            }
            RiderHomePage riderhome = new RiderHomePage(rider);
            
            
            riderhome.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

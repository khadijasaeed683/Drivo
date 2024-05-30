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

namespace UberNew.UI.RiderUI
{
    public partial class RiderNotifications : Form
    {
        Rider rider;
        internal RiderNotifications(Rider r)
        {
            InitializeComponent();
            Loads();
            this.rider = r;
        }
        public void Loads()
        {
            List<string> notification = new List<string>();
            if (notification.Count==0)
            {

                Label noRepoLabel = new Label();
                noRepoLabel.Text = "           No Notification yet.";
                noRepoLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                noRepoLabel.ForeColor = Color.Gray;
                noRepoLabel.AutoSize = true; // Set AutoSize property to true
                notificationspnl.Controls.Add(noRepoLabel);

            }
            else
            {
               Notification notifica = new Notification();
                notificationspnl.Controls.Add(notifica);

            }
            

        }

        private void RiderNotifications_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

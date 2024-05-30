using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drivo;


namespace UberNew.UI.DriverUI
{
    public partial class AcceptRide : Form
    {
        int tripId;
        Driver driver;
        internal AcceptRide(int tripid, Driver dr)
        {
            InitializeComponent();
            this.tripId = tripid;
            driver = dr;
        }

        private void confirmRideAcceptpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRides vr = new ViewRides(driver);
            vr.Show();
        }



        private void cnfrmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectHandler.GetTripCrud();
               ObjectHandler.GetTripCrud().UpdateArrivalMinutes(tripId, Convert.ToInt32(arrivalmincombo.Text));
                ObjectHandler.GetTripCrud().UpdateRideStatusToAccepted(tripId, driver.getPhoneNumber(), driver.getDriverIdCard());
                MessageBox.Show("Ride Accepted! Check Active Ride to see status");
                

                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRides vr = new ViewRides(driver);
            vr.Show();
        }
    }
    }


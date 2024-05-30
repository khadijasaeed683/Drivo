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
    public partial class ActiveRide : Form
    {
        Rider rider=new Rider();
        internal ActiveRide(Rider r)
        {
            InitializeComponent();
            rider = r;
            Display();
        }
        List<Trip> tripsList = new List<Trip>();

        private void Display()
        {
            try
            {
                riderridesgrid.Rows.Clear();

                tripsList.Clear();
                tripsList = ObjectHandler.GetTripCrud().LoadActiveTripsForRiderToList(rider.getID());

                foreach (Trip t in tripsList)
                {
                    if (t.getPickupLocation()!="Anonymous")
                    {
                        Driver d = t.getDriver();
                        if (d != null)
                        {

                            riderridesgrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), "Accepted", d.getName(), t.getDriverPhoneNumber());

                        }
                        else
                        {
                            riderridesgrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), "Waiting" , "null", "null");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == riderridesgrid.Columns["Delete"].Index)
                {
                    // Check if the column exists
                    if (riderridesgrid.Columns.Contains("Ride_Id") && riderridesgrid.Rows.Count > e.RowIndex)
                    {
                        // Get the ride ID from the selected row
                        int rideId = Convert.ToInt32(riderridesgrid.Rows[e.RowIndex].Cells["Ride_Id"].Value);

                        if (MessageBox.Show("Are you sure you want to Delete this Ride Request?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Update the database to anonymize the ride
                            ObjectHandler.GetTripCrud().DeleteRide(rideId);
                           // TripCrudDB.DeleteRide(rideId, Utils.ConnectionString());

                            // Reload the pending rides
                            Display();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

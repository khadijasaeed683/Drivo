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

namespace UberNew.UI.DriverUI
{
    public partial class ActiveRideDriver : Form
    {
        Driver driver;
        internal ActiveRideDriver(Driver d)
        {
            InitializeComponent();
            this.driver = d;
            Display();
        }

        List<Trip> tripsList = new List<Trip>();

        private void Display()
        {
            try
            {
                viewridesgrid.Rows.Clear();

                tripsList.Clear();
                ObjectHandler.GetTripCrud().LoadInCompleteTripsForDriverToList(driver.getDriverIdCard());
               // tripsList = TripCrudDB.LoadInCompleteTripsForDriverToList(driver.getDriverIdCard());

                foreach (Trip t in tripsList)
                {
                    if (t.getPickupLocation() != "Anonymous")
                    {
                        Rider r = t.getRider();
                        if (r != null)
                        {

                            viewridesgrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), t.getFare(),r.getPhoneNumber());

                        }
                        else
                        {
                            viewridesgrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), "Waiting");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void viewridesgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == viewridesgrid.Columns["Completed"].Index)
                {
                    // Check if the column exists
                    if (viewridesgrid.Columns.Contains("RideId") && viewridesgrid.Rows.Count > e.RowIndex)
                    {
                        // Get the ride ID from the selected row
                        int rideId = Convert.ToInt32(viewridesgrid.Rows[e.RowIndex].Cells["RideId"].Value);

                        // Prompt for confirmation before deleting
                        if (MessageBox.Show("Have you completed this Trip?", "Confirm Completion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            // Update the database to anonymize the ride
                            ObjectHandler.GetTripCrud().CompleteTrip(rideId);

                         //   TripCrudDB.CompleteTrip(rideId);   Before Object Handler Implementaion


                            // Reload the pending rides
                            Display();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

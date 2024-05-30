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
    public partial class RiderRideHistory : Form
    {
        Rider rider;
        internal RiderRideHistory(Rider r)
        {
            InitializeComponent();
            rider = r;
            Display();
        }
        List<Trip> intripsList = new List<Trip>();

        private void Display()
        {
            try
            {
                rideshistorygrid.Rows.Clear();

                intripsList.Clear();
                intripsList = TripCrudDB.LoadInActiveTripsForRiderToList(rider.getID());

                foreach (Trip t in intripsList)
                {
                    if (t.getPickupLocation() != "Anonymous")
                    {
                        Driver d = t.getDriver();
                        if (d != null)
                        {

                            rideshistorygrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), d.getName(), d.getPhoneNumber());

                        }
                        else
                        {
                            rideshistorygrid.Rows.Add(t.getTripId(), t.getPickupLocation(), t.getDropoffLocation(), "null", "null");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void rideshistorygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

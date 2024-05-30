using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.UI.AdminUI;
using UberNew.UI.DriverUI;
using Drivo;


namespace UberNew.UI
{
    public partial class ViewRides : Form
    {
        Driver driver;
        internal ViewRides( Driver dr)
        {
            InitializeComponent();
            Display();
           driver = dr;

        }

        private void ViewRides_Load(object sender, EventArgs e)
        {

        }
         List<Trip> tripsList = new List<Trip>();
        private void Display()
        {
            try
            {
                viewridesgrid.Rows.Clear();

                tripsList.Clear();
                tripsList = ObjectHandler.GetTripCrud().GetAllPendingRides();

                foreach (Trip t in tripsList)
                {
                    Rider rider = t.getRider();
                //  MessageBox.Show(rider.getPhoneNumber(), rider.getName() );
                    
                    viewridesgrid.Rows.Add( t.getTripId(),t.getPickupLocation(), t.getDropoffLocation(), t.getFare(),rider.getName());
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void viewridesgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewridesgrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = viewridesgrid.Rows[e.RowIndex];
                string tripId = selectedRow.Cells["RideId"].Value.ToString();


                // Open the second form
                if (tripId != null)
                {
                    AcceptRide enter = new AcceptRide(Convert.ToInt32(tripId), driver);
                    enter.Show();
                   
                }


            }
            Display();
        }

        private void ridesbtn_Click(object sender, EventArgs e)
        {

        }
    }

}

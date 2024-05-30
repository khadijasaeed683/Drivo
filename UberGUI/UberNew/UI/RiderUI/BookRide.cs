using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew;
using Drivo;

namespace UberNew.UI
{
    public partial class BookRide : Form
    {
        private double farePerKM=20;
        private Rider rider;
        Trip trip=new Trip();
        internal BookRide(Rider r)
        {
            InitializeComponent();
            rider = r;
            FillPickupAndDropoffLocations();
        }

        private void FillPickupAndDropoffLocations()
        {
            // Clear existing items in dropdown lists
            pickuptxt.Items.Clear();
            dropofftxt.Items.Clear();
            List<string> LocationsList = ObjectHandler.GetTripCrud().LoadAllLocations();
            foreach (string location in LocationsList)
            {
                pickuptxt.Items.Add(location);
                dropofftxt.Items.Add(location);
            }

        }

        public void LoadForm(Form Form)
        {

            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                if (control != ridebookpnl)
                {
                    this.Controls.Remove(control);
                }
            }

            // Cast the new form to Form
            Form formToShow = Form as Form;
            if (formToShow != null)
            {
                // Set properties for the new form
                formToShow.TopLevel = false;
                formToShow.Dock = DockStyle.Fill;

                // Add the new form to the main content area
                this.Controls.Add(formToShow);
                this.Tag = formToShow;
                formToShow.Show();
            }
        }

        private void phntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void calfarebtn_Click(object sender, EventArgs e)
        {     }

        private void pickuptxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BookRide_Load(object sender, EventArgs e)
        {

        }

        private void cnfrmbkingbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void calfarebtn_Click_1(object sender, EventArgs e)
        {
            double farePerKm = ChooseFarePerKm();
            // Trip trip = new Trip();
            trip.setPickupLocation(pickuptxt.Text);
            trip.setDropoffLocation(dropofftxt.Text);
           // trip.CalculateFare(20);
            trip.setRider(rider);
            string p=pickuptxt.Text;
            double dis=  ObjectHandler.GetTripCrud().GetDistance(p , dropofftxt.Text);
            double fare = trip.CalculateFare(farePerKm, dis);
            trip.setDistanceCovered(dis);
            trip.setFare(fare);
            faretxt.Text = fare.ToString();

        }

        private void cnfrmbkingbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item from the dropdown.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Optionally, you can reset the selection to the first item or take other actions.
                    // For example:
                    // guna2ComboBox1.SelectedIndex = 0;
                }
                else
                {
                    if ((string)guna2ComboBox1.SelectedItem == "Car")
                    {
                        farePerKM = 1005;
                    }
                    ObjectHandler.GetTripCrud().StoreTrip(trip, rider);

                    // LoadForm(new RidePending());

                    this.Hide();
                    RiderHomePage riderhome = new RiderHomePage(rider);
                    Form parentfrom = this.FindForm();
                    if (parentfrom != null)
                    {
                        ParentForm.Hide();
                    }
                    riderhome.LoadForm(new RidePending(rider));
                    riderhome.Show();

                    //MessageBox.Show("Trip Added Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private double ChooseFarePerKm()
        {
            double farePer = 0;

            try

            {
                if (guna2ComboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item from the dropdown.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((string)guna2ComboBox1.SelectedItem == "Car")
                    {
                        farePer = 50;
                    }
                    else if ((string)guna2ComboBox1.SelectedItem == "Auto")
                    {
                        farePer = 30;
                    }
                    else
                    {
                        farePer = 15;
                    }
                   
                }
                return farePer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while Choosing Fare Per Km: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return farePer;

        }

        private void ridebookpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pickuptxt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dropofftxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }
    }
}

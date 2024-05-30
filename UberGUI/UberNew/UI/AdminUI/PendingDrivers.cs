using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.DL;
using Drivo;

namespace UberNew.UI.AdminUI
{
    public partial class PendingDrivers : Form
    {
        public PendingDrivers()
        {
            InitializeComponent();
            Display();
        }
        List<Driver> drivers = new List<Driver>();
        private void Display()
        {
            try
            {
                grid.Rows.Clear();

                drivers.Clear();
                drivers = ObjectHandler.GetDriverCrud().LoadDriversWithNullDriverID();

                // Check if any drivers were loaded
                if (drivers.Count == 0)
                {
                    MessageBox.Show("No pending drivers found.");
                    return;
                }

                foreach (Driver driver in drivers)
                    {
                        grid.Rows.Add(driver.getName(), driver.getDriverIdCard(), driver.getPhoneNumber(), driver.getLicense(), driver.getCarModel());
                    }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void driversrequestsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = grid.Rows[e.RowIndex];
                string driverName = selectedRow.Cells["Name"].Value.ToString();
                string driverIdCard = selectedRow.Cells["idcard"].Value.ToString();
                // Retrieve other data as needed

                // Open the second form
                if (driverName != null && driverIdCard != null)
                {
                    EnterRiderId enter = new EnterRiderId(driverName, driverIdCard);
                    enter.Show();
                }
            }


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class ViewAllDrivers : Form
    {
        public ViewAllDrivers()
        {
            InitializeComponent();
            Display();
        }
        List<Driver> AllDrivers=new List<Driver>();
        private void Display()
        {
            try
            {
                viewallridersgrid.Rows.Clear();

                AllDrivers.Clear();
                AllDrivers = ObjectHandler.GetDriverCrud().GetAllAvailableDriversList();

                foreach (Driver d in AllDrivers)

                {

                    viewallridersgrid.Rows.Add(d.getName(), d.getPhoneNumber(), d.getID(), d.getJoiningDate());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewallridersgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viewallridersgrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = viewallridersgrid.Rows[e.RowIndex];
                int RiderId = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
                //  string driverIdCard = selectedRow.Cells["idcard"].Value.ToString();
                // Retrieve other data as needed

                // Open the second form
                if (RiderId != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Rider?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Call DeleteRider function
                        ObjectHandler.GetDriverCrud().UpdateAvailibiltyStatus(RiderId, false);
                    }
                }
            }
        }
    }
}

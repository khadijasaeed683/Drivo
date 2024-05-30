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

namespace UberNew.UI.AdminUI
{
    public partial class ViewAllRiders : Form
    {
        public ViewAllRiders()
        {
            InitializeComponent();
            Display();
        }

        List<Rider> allRiders = new List<Rider>();
        private void Display()
        {
            try
            {
                viewallridersgrid.Rows.Clear();

                allRiders.Clear();
               allRiders = ObjectHandler.GetRiderCrud().GetAllActiveRiders();

              foreach (Rider r in allRiders)

                {

                    viewallridersgrid.Rows.Add(r.getName(), r.getPhoneNumber(), r.getID(), r.getPassword());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

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
                if (RiderId != 0 )
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Rider?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Call DeleteRider function
                       bool k= ObjectHandler.GetRiderCrud().DeleteRider(RiderId);
                        if (k)
                        {
                            MessageBox.Show("Rider Deleted Successfully");
                            Display();

                        }
                        else
                        {
                            MessageBox.Show("Error Deleting Rider");

                        }
                    }
                }
            }
        }
    }
}

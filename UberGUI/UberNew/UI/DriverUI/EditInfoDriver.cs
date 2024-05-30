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

namespace UberNew.UI.DriverUI
{
    public partial class EditInfoDriver : Form
    {
        private Driver driver;
        internal EditInfoDriver(Driver d)
        {
            InitializeComponent();
            driver = d;
            nametxt.Text = driver.getName();
            phntxt.Text=driver.getPhoneNumber();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Show();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameupdatebtn_Click(object sender, EventArgs e)
        {

            try
            {
                driver.setName(nametxt.Text);
                bool check = ObjectHandler.GetDriverCrud().UpdateDriverName(driver, nametxt.Text);
                if(check)
                {
                    MessageBox.Show("Name Updated successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void confirmdeletionbtn_Click(object sender, EventArgs e)
        {
            driver.UpdateAvailibilityStatus(false);
            if(ObjectHandler.GetDriverCrud().UpdateAvailibiltyStatus(driver.getID(), false))
            {
                driver.setID(0);
                ObjectHandler.GetDriverCrud().UpdateDriverId(driver.getName(), driver.getID());
                MessageBox.Show("Driver Profile deleted");
                this.Hide();
                Form parentfrom = this.FindForm();
                if (parentfrom != null)
                {
                    ParentForm.Hide();
                }
                Form1 f = new Form1();
                f.Show();
            }
        }

        private void phnupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                driver.setName(nametxt.Text);
                bool check = ObjectHandler.GetDriverCrud().UpdateDriverPhoneNumber(driver, phntxt.Text);
                if (check)
                {
                    MessageBox.Show("Phone Number Updated successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void canceldeletionbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

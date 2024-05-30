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
    public partial class RiderEditInfo : Form
    {
        Rider rider;
        internal RiderEditInfo(Rider r)
        {

            InitializeComponent();
            rider = r;
            nametxt.Text = rider.getName();
            pastxt.Text = rider.getPassword();
            phntxt.Text = rider.getPhoneNumber();
            emailtxt.Text = rider.getEmail();

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectHandler.GetRiderCrud().UpdateRiderName(rider, nametxt.Text);
                MessageBox.Show("User Name Updated Successfully.", "MessageBox", MessageBoxButtons.OK);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void passupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectHandler.GetRiderCrud().UpdateRiderPassword(rider, pastxt.Text);
                MessageBox.Show("User Password Updated Successfully.", "MessageBox", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void phnupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectHandler.GetRiderCrud().UpdateRiderPhoneNumber(rider, phntxt.Text);
                MessageBox.Show("User Phone Number Updated Successfully.", "MessageBox", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emailupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectHandler.GetRiderCrud().UpdateRiderEmail(rider, emailtxt.Text);
                MessageBox.Show("User email Updated Successfully.", "MessageBox", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

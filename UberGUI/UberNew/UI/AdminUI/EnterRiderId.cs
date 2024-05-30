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
    public partial class EnterRiderId : Form
    {
        public string driverName;
        public string driverIdCard;
        public EnterRiderId(string driverName, string driverIdCard)
        {
            InitializeComponent();
            // Assign received data to local variables
            this.driverName = driverName;
            this.driverIdCard = driverIdCard;
        }

        private void idokbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idtxt.Text);
                if (ObjectHandler.GetDriverCrud().UpdateDriverId(driverName, id))
                {
                    MessageBox.Show("ID Entered Successfully"); 
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

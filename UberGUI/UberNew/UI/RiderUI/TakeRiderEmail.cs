using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.Utility;

namespace UberNew.UI.RiderUI
{
    public partial class TakeRiderEmail : UserControl
    {
        private ErrorProvider errorProvider;


        // Define an event to notify the parent form to switch to the password control
        public event EventHandler NextClicked;
        public event EventHandler BackClicked;


        public TakeRiderEmail()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Disable blinking

        }
        public string GetEmail()
        {  
            return emailtxt.Text;
        }

        private void emlnxtbtn_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void OnNextClicked()
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnBackClicked()
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

       /* private void backPicBox_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);

        }
*/
        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TakeRiderEmail_Load(object sender, EventArgs e)
        {

        }

        private void emlnxtbtn_Click_1(object sender, EventArgs e)
        {
            // Raise the event indicating that the next button is clicked

            string email = emailtxt.Text.Trim();
            if (Validations.IsValidEmail(email))
            {
                errorProvider.SetError(emailtxt, ""); // Clear error icon if email is valid
                OnNextClicked();
            }
            else
            {
                errorProvider.SetError(emailtxt, "Invalid email address"); // Display error icon
            }
        }

        private void backPicBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OnBackClicked();            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void emailpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        // Other event handlers and methods...
    }
}

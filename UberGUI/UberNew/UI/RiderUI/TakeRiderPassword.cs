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
    public partial class TakeRiderPassword : UserControl
    {
        public string UserName;
        public string Email;

        internal TakeRiderPassword(string n, string e)
        {
            InitializeComponent();
            UserName = n;
            Email = e;
            
        }
        public string EnteredPassword
        {
            get { return passxt.Text; }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Rider rd=new Rider();
           rd.setName(UserName);
           rd.setEmail(Email);
           rd.setPassword(passxt.Text);
           Rider CheckRider = ObjectHandler.GetRiderCrud().SignIn(rd);
           if (CheckRider!=null)
           {
                CloseAllFormsAndControls();

                RiderHomePage rh =new RiderHomePage(CheckRider);
               rh.Show();
           }
           else
           {
               MessageBox.Show("User Not Found");
                CloseAllFormsAndControls();

                RiderSignIn rs = new RiderSignIn();
                rs.Show();
           }
        }
        private void CloseAllFormsAndControls()
        {
            // Close the current form (RiderSignIn)
            this.Hide();

            // Close the parent form (if any)
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                parentForm.Hide();
            }

            // Close any other open forms
            foreach (Form form in Application.OpenForms)
            {
                if (!ReferenceEquals(form, this) && !ReferenceEquals(form, parentForm))
                {
                    form.Hide();
                }
            }
        }


        private void backpicbox_Click(object sender, EventArgs e)
        {

        }

        private void passxt_TextChanged(object sender, EventArgs e)
        {

            
            
                passxt.PasswordChar = '*'; // Show password in '*' form
            
        }

        private void showpasscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheckbox.Checked)
            {
                passxt.PasswordChar = '\0'; // Show password in its original form
            }
            else
            {
                passxt.PasswordChar = '*'; // Show password in '*' form
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

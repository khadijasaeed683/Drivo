using Drivo;
using System;
using System.Drawing;
using System.Windows.Forms;
using UberNew.Utility;

namespace UberNew.UI
{
    public partial class RiderSignUp : Form
    {
        private ErrorProvider emailErrorProvider;
        private ErrorProvider UserNameErrorProvider;




        public RiderSignUp()
        {
            InitializeComponent();
            emailErrorProvider = new ErrorProvider();
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Disable blinking
                                                                        // emailErrorProvider.Icon = UberNew.Properties.Resources.;
                                                                        // Load the image resource
                                                                        // Bitmap image = Properties.Resources._352020_arrow_back_icon;
                                                                        // Convert the image to an Icon
                                                                        // Icon icon = Icon.FromHandle(image.GetHicon());
                                                                        // Assign the custom icon to the ErrorProvider
                                                                        //   emailErrorProvider.Icon = icon;


            UserNameErrorProvider = new ErrorProvider();
            UserNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Disable blinking


        }

        private void userNmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RiderSignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderSignIn s = new RiderSignIn();
            s.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderSignIn si = new RiderSignIn();
            si.Show();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                passtxt.PasswordChar = '\0'; // Show password in its original form
            }
            else
            {
                passtxt.PasswordChar = '*'; // Show password in '*' form
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {


            string email = emailtxt.Text.Trim();
            string name= userNmtxt.Text.Trim();

            if (Validations.IsValidEmail(email) && ObjectHandler.GetRiderCrud().IsUsernameUnique(name))
            {

                Rider rd = new Rider(userNmtxt.Text, emailtxt.Text, passtxt.Text, addresstxt.Text, phonetxt.Text);
                bool c = ObjectHandler.GetRiderCrud().StoreUser(rd);
                if (c == true)
                {
                    MessageBox.Show("Account Created Successfully");
                    CloseAllFormsAndControls();
                    Form1 rh = new Form1();
                    rh.Show();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Correct Information!");
            }
        }

        private void userNmtxt_TextChanged_1(object sender, EventArgs e)
        {
            string nm = userNmtxt.Text.Trim();
            if (ObjectHandler.GetRiderCrud().IsUsernameUnique(nm))
            {
                UserNameErrorProvider.SetError(userNmtxt, ""); // Clear error icon if email is valid

            }
            else
            {
                UserNameErrorProvider.SetError(userNmtxt, "This User Name Already Exists"); // Display error icon
            }
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {
            string email = emailtxt.Text.Trim();
            if (Validations.IsValidEmail(email))
            {
                emailErrorProvider.SetError(emailtxt, ""); // Clear error icon if email is valid

            }
            else
            {
                emailErrorProvider.SetError(emailtxt, "Invalid email address"); // Display error icon
            }
        }

        private void DriveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverRegistration dr = new DriverRegistration();
            dr.Show();
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

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            passtxt.PasswordChar = '*'; // Show password in '*' form

        }
    }
}

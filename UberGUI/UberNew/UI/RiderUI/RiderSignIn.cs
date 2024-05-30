using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberNew.UI.RiderUI;
using Drivo;


namespace UberNew.UI
{
    public partial class RiderSignIn : Form
    {
        static RiderSignIn _obj;
        public string usernm;
        public string password;
        public string email;
        public static RiderSignIn Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj= new RiderSignIn();
                }
                return _obj;
            }
        }
        public Panel PanelConatiner
        {
            get
            {
                return dynamicinputpnl;
            }
            set
            {
                this.dynamicinputpnl = (Guna.UI2.WinForms.Guna2Panel)value;
            }
        }
        public Guna.UI2.WinForms.Guna2Button BackButton
        {
            get
            {
                return bckbtn;
            }
            set
            {
                bckbtn = value;           }
        }
        public RiderSignIn()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f=new Form1();
            f.Show();
        }

        private void LoadTakeRiderEmailControl()
        {
            TakeRiderEmail takeRiderEmail = new TakeRiderEmail();
            
            takeRiderEmail.NextClicked += TakeRiderEmail_NextClicked; 
            takeRiderEmail.BackClicked += TakeRiderEmail_BackClicked; // Subscribe to the BackClicked event
          /*  dynamicinputpnl.SendToBack();
            takeRiderEmail.BringToFront();*/

            dynamicinputpnl.Controls.Clear();
             dynamicinputpnl.Controls.Add(takeRiderEmail);
            takeRiderEmail.Dock = DockStyle.Fill;
        }
       
        private void TakeRiderEmail_BackClicked(object sender, EventArgs e)
        {
            // Show the sign-in page panel when the back button is clicked
            dynamicinputpnl.Visible = true;
            bckbtn.Visible = false;
            dynamicinputpnl.BringToFront(); // Bring the dynamic input panel to the front

        }
        private void TakeRiderEmail_NextClicked(object sender, EventArgs e)
        {
             email = ((TakeRiderEmail)sender).GetEmail();

            // Load the TakeRiderPassword control when the NextClicked event is clicked
            LoadTakeRiderPasswordControl();

        }
        private void LoadTakeRiderPasswordControl()
        {
            TakeRiderPassword takeRiderPassword = new TakeRiderPassword(userNmtxt.Text,email);
            password= takeRiderPassword.EnteredPassword;
            dynamicinputpnl.Controls.Clear();
            dynamicinputpnl.Controls.Add(takeRiderPassword);
            takeRiderPassword.Dock = DockStyle.Fill;
        }

        private void registerbtn_Click(object sender, EventArgs e) //next
        {
            LoadTakeRiderEmailControl();


        }

        private void userNmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RiderSignIn_Load(object sender, EventArgs e)
        {
            bckbtn.Visible = false;
            dynamicinputpnl.BringToFront();

           


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderSignUp rs=new RiderSignUp();
            rs.Show();
        }

        private void dynamicinputpnl_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SignIn()
        {
             Rider rd=new Rider();
            rd.setName(userNmtxt.Text);
            rd.setEmail(email);
            rd.setPassword(password);

            Rider CheckRider = ObjectHandler.GetRiderCrud().SignIn(rd);
            if (CheckRider!=null)
            {
                this.Hide();
                RiderHomePage rh=new RiderHomePage(CheckRider);
                rh.Show();
            }
            else
            {
                MessageBox.Show(rd.getName(),rd.getPassword());
            }


        }
        private void CloseAllFormsAndControls()
        {
            // Close the current form (RiderSignIn)
            this.Hide();

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

        private void DriveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverSignIn ds=new DriverSignIn();
            ds.Show();
        }
    }
}

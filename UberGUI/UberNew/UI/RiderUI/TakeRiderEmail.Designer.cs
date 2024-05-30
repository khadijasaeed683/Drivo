namespace UberNew.UI.RiderUI
{
    partial class TakeRiderEmail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailpnl = new Guna.UI2.WinForms.Guna2Panel();
            this.backPicBox = new System.Windows.Forms.PictureBox();
            this.emlnxtbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailpnl
            // 
            this.emailpnl.Controls.Add(this.backPicBox);
            this.emailpnl.Controls.Add(this.emlnxtbtn);
            this.emailpnl.Controls.Add(this.label5);
            this.emailpnl.Controls.Add(this.emailtxt);
            this.emailpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailpnl.Location = new System.Drawing.Point(0, 0);
            this.emailpnl.Name = "emailpnl";
            this.emailpnl.Size = new System.Drawing.Size(354, 191);
            this.emailpnl.TabIndex = 0;
            this.emailpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.emailpnl_Paint);
            // 
            // backPicBox
            // 
            this.backPicBox.Location = new System.Drawing.Point(77, 129);
            this.backPicBox.Name = "backPicBox";
            this.backPicBox.Size = new System.Drawing.Size(57, 36);
            this.backPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPicBox.TabIndex = 64;
            this.backPicBox.TabStop = false;
            this.backPicBox.Click += new System.EventHandler(this.backPicBox_Click_1);
            // 
            // emlnxtbtn
            // 
            this.emlnxtbtn.AutoRoundedCorners = true;
            this.emlnxtbtn.BackColor = System.Drawing.Color.Transparent;
            this.emlnxtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emlnxtbtn.BorderRadius = 17;
            this.emlnxtbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.emlnxtbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.emlnxtbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.emlnxtbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.emlnxtbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.emlnxtbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emlnxtbtn.ForeColor = System.Drawing.Color.White;
            this.emlnxtbtn.Location = new System.Drawing.Point(199, 108);
            this.emlnxtbtn.Name = "emlnxtbtn";
            this.emlnxtbtn.PressedColor = System.Drawing.Color.Gray;
            this.emlnxtbtn.Size = new System.Drawing.Size(91, 36);
            this.emlnxtbtn.TabIndex = 63;
            this.emlnxtbtn.Text = "Next";
            this.emlnxtbtn.Click += new System.EventHandler(this.emlnxtbtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Enter Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.AutoRoundedCorners = true;
            this.emailtxt.BorderRadius = 17;
            this.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxt.DefaultText = "";
            this.emailtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Location = new System.Drawing.Point(90, 57);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.PlaceholderText = "Enter Email";
            this.emailtxt.SelectedText = "";
            this.emailtxt.Size = new System.Drawing.Size(200, 36);
            this.emailtxt.TabIndex = 61;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged_1);
            // 
            // TakeRiderEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.emailpnl);
            this.Name = "TakeRiderEmail";
            this.Size = new System.Drawing.Size(354, 191);
            this.Load += new System.EventHandler(this.TakeRiderEmail_Load);
            this.emailpnl.ResumeLayout(false);
            this.emailpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel emailpnl;
        private System.Windows.Forms.PictureBox backPicBox;
        private Guna.UI2.WinForms.Guna2Button emlnxtbtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox emailtxt;
    }
}

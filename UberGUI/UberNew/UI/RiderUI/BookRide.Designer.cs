namespace UberNew.UI
{
    partial class BookRide
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ridebookpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dropofftxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pickuptxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cnfrmbkingbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.faretxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.calfarebtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ridebookpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ridebookpnl
            // 
            this.ridebookpnl.Controls.Add(this.label1);
            this.ridebookpnl.Controls.Add(this.guna2ComboBox1);
            this.ridebookpnl.Controls.Add(this.dropofftxt);
            this.ridebookpnl.Controls.Add(this.pickuptxt);
            this.ridebookpnl.Controls.Add(this.cnfrmbkingbtn);
            this.ridebookpnl.Controls.Add(this.label5);
            this.ridebookpnl.Controls.Add(this.label2);
            this.ridebookpnl.Controls.Add(this.faretxt);
            this.ridebookpnl.Controls.Add(this.calfarebtn);
            this.ridebookpnl.Controls.Add(this.label3);
            this.ridebookpnl.Controls.Add(this.exitBtn);
            this.ridebookpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ridebookpnl.Location = new System.Drawing.Point(0, 0);
            this.ridebookpnl.Name = "ridebookpnl";
            this.ridebookpnl.Size = new System.Drawing.Size(656, 533);
            this.ridebookpnl.TabIndex = 0;
            this.ridebookpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.ridebookpnl_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Choose Vehicle Type";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Auto",
            "Car",
            "Bike"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(241, 269);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(193, 36);
            this.guna2ComboBox1.TabIndex = 111;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // dropofftxt
            // 
            this.dropofftxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropofftxt.BackColor = System.Drawing.Color.Transparent;
            this.dropofftxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropofftxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropofftxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropofftxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropofftxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dropofftxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dropofftxt.ItemHeight = 30;
            this.dropofftxt.Items.AddRange(new object[] {
            "Department of Computer Science",
            "Department of Electrical Engineering",
            "Girls Service Center (GSC)",
            "Students Service Center (SSC)"});
            this.dropofftxt.Location = new System.Drawing.Point(241, 210);
            this.dropofftxt.Name = "dropofftxt";
            this.dropofftxt.Size = new System.Drawing.Size(193, 36);
            this.dropofftxt.TabIndex = 110;
            this.dropofftxt.SelectedIndexChanged += new System.EventHandler(this.dropofftxt_SelectedIndexChanged);
            // 
            // pickuptxt
            // 
            this.pickuptxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickuptxt.BackColor = System.Drawing.Color.Transparent;
            this.pickuptxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pickuptxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickuptxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pickuptxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pickuptxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pickuptxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pickuptxt.ItemHeight = 30;
            this.pickuptxt.Items.AddRange(new object[] {
            "Department of Computer Science",
            "Department of Electrical Engineering",
            "Girls Service Center (GSC)",
            "Students Service Center (SSC)"});
            this.pickuptxt.Location = new System.Drawing.Point(241, 122);
            this.pickuptxt.Name = "pickuptxt";
            this.pickuptxt.Size = new System.Drawing.Size(193, 36);
            this.pickuptxt.TabIndex = 109;
            this.pickuptxt.SelectedIndexChanged += new System.EventHandler(this.pickuptxt_SelectedIndexChanged_1);
            // 
            // cnfrmbkingbtn
            // 
            this.cnfrmbkingbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnfrmbkingbtn.AutoRoundedCorners = true;
            this.cnfrmbkingbtn.BackColor = System.Drawing.Color.Transparent;
            this.cnfrmbkingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cnfrmbkingbtn.BorderRadius = 17;
            this.cnfrmbkingbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfrmbkingbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfrmbkingbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfrmbkingbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfrmbkingbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.cnfrmbkingbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnfrmbkingbtn.ForeColor = System.Drawing.Color.White;
            this.cnfrmbkingbtn.Location = new System.Drawing.Point(317, 371);
            this.cnfrmbkingbtn.Name = "cnfrmbkingbtn";
            this.cnfrmbkingbtn.PressedColor = System.Drawing.Color.Gray;
            this.cnfrmbkingbtn.Size = new System.Drawing.Size(117, 37);
            this.cnfrmbkingbtn.TabIndex = 108;
            this.cnfrmbkingbtn.Text = "Confirm Request";
            this.cnfrmbkingbtn.Click += new System.EventHandler(this.cnfrmbkingbtn_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 107;
            this.label5.Text = "Enter DropOff Loction";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Enter Pickup Loction";
            // 
            // faretxt
            // 
            this.faretxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faretxt.AutoRoundedCorners = true;
            this.faretxt.BorderRadius = 17;
            this.faretxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.faretxt.DefaultText = "";
            this.faretxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.faretxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.faretxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.faretxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.faretxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.faretxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.faretxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.faretxt.Location = new System.Drawing.Point(234, 329);
            this.faretxt.Name = "faretxt";
            this.faretxt.PasswordChar = '\0';
            this.faretxt.PlaceholderText = "";
            this.faretxt.SelectedText = "";
            this.faretxt.Size = new System.Drawing.Size(200, 36);
            this.faretxt.TabIndex = 105;
            // 
            // calfarebtn
            // 
            this.calfarebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calfarebtn.AutoRoundedCorners = true;
            this.calfarebtn.BackColor = System.Drawing.Color.Transparent;
            this.calfarebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calfarebtn.BorderRadius = 17;
            this.calfarebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calfarebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calfarebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calfarebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calfarebtn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.calfarebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calfarebtn.ForeColor = System.Drawing.Color.White;
            this.calfarebtn.Location = new System.Drawing.Point(114, 321);
            this.calfarebtn.Name = "calfarebtn";
            this.calfarebtn.PressedColor = System.Drawing.Color.Gray;
            this.calfarebtn.Size = new System.Drawing.Size(102, 37);
            this.calfarebtn.TabIndex = 104;
            this.calfarebtn.Text = "Calculate Fare";
            this.calfarebtn.Click += new System.EventHandler(this.calfarebtn_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 103;
            this.label3.Text = "Ride Booking";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.AutoRoundedCorners = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 17;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.DarkRed;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(525, 55);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.Gray;
            this.exitBtn.Size = new System.Drawing.Size(73, 36);
            this.exitBtn.TabIndex = 102;
            this.exitBtn.Text = "Exit";
            // 
            // BookRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 533);
            this.Controls.Add(this.ridebookpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookRide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRide";
            this.Load += new System.EventHandler(this.BookRide_Load);
            this.ridebookpnl.ResumeLayout(false);
            this.ridebookpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ridebookpnl;
        private Guna.UI2.WinForms.Guna2ComboBox dropofftxt;
        private Guna.UI2.WinForms.Guna2ComboBox pickuptxt;
        private Guna.UI2.WinForms.Guna2Button cnfrmbkingbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox faretxt;
        private Guna.UI2.WinForms.Guna2Button calfarebtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label1;
    }
}
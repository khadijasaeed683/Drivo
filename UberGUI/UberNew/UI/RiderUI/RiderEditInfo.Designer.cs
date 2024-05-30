namespace UberNew.UI.RiderUI
{
    partial class RiderEditInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.passupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.pastxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phnupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.phntxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.emailtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailupdatebtn);
            this.panel1.Controls.Add(this.emailtxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.phnupdatebtn);
            this.panel1.Controls.Add(this.phntxt);
            this.panel1.Controls.Add(this.passupdatebtn);
            this.panel1.Controls.Add(this.pastxt);
            this.panel1.Controls.Add(this.nameupdatebtn);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 455);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 105;
            this.label1.Text = "Account Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "Phone Number";
            // 
            // nametxt
            // 
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.DefaultText = "";
            this.nametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.Location = new System.Drawing.Point(173, 124);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "";
            this.nametxt.SelectedText = "";
            this.nametxt.Size = new System.Drawing.Size(200, 35);
            this.nametxt.TabIndex = 109;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // nameupdatebtn
            // 
            this.nameupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nameupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nameupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nameupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nameupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nameupdatebtn.FillColor = System.Drawing.Color.Maroon;
            this.nameupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameupdatebtn.ForeColor = System.Drawing.Color.White;
            this.nameupdatebtn.Location = new System.Drawing.Point(418, 124);
            this.nameupdatebtn.Name = "nameupdatebtn";
            this.nameupdatebtn.Size = new System.Drawing.Size(66, 35);
            this.nameupdatebtn.TabIndex = 110;
            this.nameupdatebtn.Text = "Update";
            this.nameupdatebtn.Click += new System.EventHandler(this.nameupdatebtn_Click);
            // 
            // passupdatebtn
            // 
            this.passupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.passupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passupdatebtn.FillColor = System.Drawing.Color.Maroon;
            this.passupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passupdatebtn.ForeColor = System.Drawing.Color.White;
            this.passupdatebtn.Location = new System.Drawing.Point(418, 212);
            this.passupdatebtn.Name = "passupdatebtn";
            this.passupdatebtn.Size = new System.Drawing.Size(66, 35);
            this.passupdatebtn.TabIndex = 112;
            this.passupdatebtn.Text = "Update";
            this.passupdatebtn.Click += new System.EventHandler(this.passupdatebtn_Click);
            // 
            // pastxt
            // 
            this.pastxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pastxt.DefaultText = "";
            this.pastxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pastxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pastxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pastxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pastxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pastxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pastxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pastxt.Location = new System.Drawing.Point(173, 212);
            this.pastxt.Name = "pastxt";
            this.pastxt.PasswordChar = '\0';
            this.pastxt.PlaceholderText = "";
            this.pastxt.SelectedText = "";
            this.pastxt.Size = new System.Drawing.Size(200, 36);
            this.pastxt.TabIndex = 111;
            // 
            // phnupdatebtn
            // 
            this.phnupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phnupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.phnupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.phnupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.phnupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.phnupdatebtn.FillColor = System.Drawing.Color.Maroon;
            this.phnupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phnupdatebtn.ForeColor = System.Drawing.Color.White;
            this.phnupdatebtn.Location = new System.Drawing.Point(418, 371);
            this.phnupdatebtn.Name = "phnupdatebtn";
            this.phnupdatebtn.Size = new System.Drawing.Size(66, 35);
            this.phnupdatebtn.TabIndex = 114;
            this.phnupdatebtn.Text = "Update";
            this.phnupdatebtn.Click += new System.EventHandler(this.phnupdatebtn_Click);
            // 
            // phntxt
            // 
            this.phntxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phntxt.DefaultText = "";
            this.phntxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phntxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phntxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phntxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phntxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phntxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phntxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phntxt.Location = new System.Drawing.Point(173, 370);
            this.phntxt.Name = "phntxt";
            this.phntxt.PasswordChar = '\0';
            this.phntxt.PlaceholderText = "";
            this.phntxt.SelectedText = "";
            this.phntxt.Size = new System.Drawing.Size(200, 36);
            this.phntxt.TabIndex = 113;
            // 
            // emailupdatebtn
            // 
            this.emailupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.emailupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.emailupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.emailupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.emailupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.emailupdatebtn.FillColor = System.Drawing.Color.Maroon;
            this.emailupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailupdatebtn.ForeColor = System.Drawing.Color.White;
            this.emailupdatebtn.Location = new System.Drawing.Point(418, 290);
            this.emailupdatebtn.Name = "emailupdatebtn";
            this.emailupdatebtn.Size = new System.Drawing.Size(66, 35);
            this.emailupdatebtn.TabIndex = 117;
            this.emailupdatebtn.Text = "Update";
            this.emailupdatebtn.Click += new System.EventHandler(this.emailupdatebtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxt.DefaultText = "";
            this.emailtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Location = new System.Drawing.Point(173, 290);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.PlaceholderText = "";
            this.emailtxt.SelectedText = "";
            this.emailtxt.Size = new System.Drawing.Size(200, 36);
            this.emailtxt.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Email";
            // 
            // RiderEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 455);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RiderEditInfo";
            this.Text = "RiderEditInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button phnupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox phntxt;
        private Guna.UI2.WinForms.Guna2Button passupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox pastxt;
        private Guna.UI2.WinForms.Guna2Button nameupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button emailupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox emailtxt;
        private System.Windows.Forms.Label label5;
    }
}
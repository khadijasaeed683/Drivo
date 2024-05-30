namespace UberNew.UI.DriverUI
{
    partial class EditInfoDriver
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
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmdeletionbtn = new Guna.UI2.WinForms.Guna2Button();
            this.canceldeletionbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.phnupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.phntxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameupdatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.phnupdatebtn);
            this.panel1.Controls.Add(this.phntxt);
            this.panel1.Controls.Add(this.nameupdatebtn);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(205, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 121;
            this.label3.Text = "Want to delete Driver Profile?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.confirmdeletionbtn);
            this.flowLayoutPanel1.Controls.Add(this.canceldeletionbtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(418, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 109);
            this.flowLayoutPanel1.TabIndex = 120;
            this.flowLayoutPanel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 40);
            this.label6.TabIndex = 122;
            this.label6.Text = "Are you sure you want\r\n to delete Driver Profile?";
            // 
            // confirmdeletionbtn
            // 
            this.confirmdeletionbtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.confirmdeletionbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmdeletionbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmdeletionbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmdeletionbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmdeletionbtn.FillColor = System.Drawing.Color.Maroon;
            this.confirmdeletionbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmdeletionbtn.ForeColor = System.Drawing.Color.White;
            this.confirmdeletionbtn.Location = new System.Drawing.Point(3, 43);
            this.confirmdeletionbtn.Name = "confirmdeletionbtn";
            this.confirmdeletionbtn.Size = new System.Drawing.Size(66, 35);
            this.confirmdeletionbtn.TabIndex = 123;
            this.confirmdeletionbtn.Text = "Delete";
            this.confirmdeletionbtn.Click += new System.EventHandler(this.confirmdeletionbtn_Click);
            // 
            // canceldeletionbtn
            // 
            this.canceldeletionbtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.canceldeletionbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.canceldeletionbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.canceldeletionbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.canceldeletionbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.canceldeletionbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.canceldeletionbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.canceldeletionbtn.ForeColor = System.Drawing.Color.White;
            this.canceldeletionbtn.Location = new System.Drawing.Point(75, 43);
            this.canceldeletionbtn.Name = "canceldeletionbtn";
            this.canceldeletionbtn.Size = new System.Drawing.Size(66, 35);
            this.canceldeletionbtn.TabIndex = 124;
            this.canceldeletionbtn.Text = "Cancel";
            this.canceldeletionbtn.Click += new System.EventHandler(this.canceldeletionbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebtn.FillColor = System.Drawing.Color.Maroon;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(307, 362);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(66, 35);
            this.deletebtn.TabIndex = 119;
            this.deletebtn.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // phnupdatebtn
            // 
            this.phnupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phnupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.phnupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.phnupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.phnupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.phnupdatebtn.FillColor = System.Drawing.Color.DarkGreen;
            this.phnupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phnupdatebtn.ForeColor = System.Drawing.Color.White;
            this.phnupdatebtn.Location = new System.Drawing.Point(418, 240);
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
            this.phntxt.Location = new System.Drawing.Point(173, 239);
            this.phntxt.Name = "phntxt";
            this.phntxt.PasswordChar = '\0';
            this.phntxt.PlaceholderText = "";
            this.phntxt.SelectedText = "";
            this.phntxt.Size = new System.Drawing.Size(200, 36);
            this.phntxt.TabIndex = 113;
            // 
            // nameupdatebtn
            // 
            this.nameupdatebtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nameupdatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nameupdatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nameupdatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nameupdatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nameupdatebtn.FillColor = System.Drawing.Color.DarkGreen;
            this.nameupdatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameupdatebtn.ForeColor = System.Drawing.Color.White;
            this.nameupdatebtn.Location = new System.Drawing.Point(418, 124);
            this.nameupdatebtn.Name = "nameupdatebtn";
            this.nameupdatebtn.Size = new System.Drawing.Size(66, 35);
            this.nameupdatebtn.TabIndex = 110;
            this.nameupdatebtn.Text = "Update";
            this.nameupdatebtn.Click += new System.EventHandler(this.nameupdatebtn_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 108;
            this.label4.Text = "Phone Number";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 105;
            this.label1.Text = "Account Information";
            // 
            // EditInfoDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditInfoDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditInfoDriver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button phnupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox phntxt;
        private Guna.UI2.WinForms.Guna2Button nameupdatebtn;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button deletebtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button confirmdeletionbtn;
        private Guna.UI2.WinForms.Guna2Button canceldeletionbtn;
    }
}
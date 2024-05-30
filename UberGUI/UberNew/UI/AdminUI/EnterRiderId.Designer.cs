namespace UberNew.UI.AdminUI
{
    partial class EnterRiderId
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.closebtn = new Guna.UI2.WinForms.Guna2Button();
            this.idokbtn = new Guna.UI2.WinForms.Guna2Button();
            this.notelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.closebtn);
            this.guna2Panel1.Controls.Add(this.idokbtn);
            this.guna2Panel1.Controls.Add(this.notelbl);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.idtxt);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(474, 416);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // closebtn
            // 
            this.closebtn.BorderColor = System.Drawing.Color.Aquamarine;
            this.closebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closebtn.FillColor = System.Drawing.Color.DarkRed;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(390, 24);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(59, 27);
            this.closebtn.TabIndex = 108;
            this.closebtn.Text = "Close";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // idokbtn
            // 
            this.idokbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.idokbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.idokbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.idokbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.idokbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idokbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idokbtn.ForeColor = System.Drawing.Color.White;
            this.idokbtn.Location = new System.Drawing.Point(202, 189);
            this.idokbtn.Name = "idokbtn";
            this.idokbtn.Size = new System.Drawing.Size(58, 37);
            this.idokbtn.TabIndex = 107;
            this.idokbtn.Text = "OK";
            this.idokbtn.Click += new System.EventHandler(this.idokbtn_Click);
            // 
            // notelbl
            // 
            this.notelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notelbl.AutoSize = true;
            this.notelbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelbl.ForeColor = System.Drawing.Color.White;
            this.notelbl.Location = new System.Drawing.Point(109, 317);
            this.notelbl.Name = "notelbl";
            this.notelbl.Size = new System.Drawing.Size(265, 40);
            this.notelbl.TabIndex = 106;
            this.notelbl.Text = "Note: Driver ID should be Numeric \r\nand unique for each driver.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 33);
            this.label3.TabIndex = 105;
            this.label3.Text = "Enter Driver Id";
            // 
            // idtxt
            // 
            this.idtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtxt.DefaultText = "";
            this.idtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idtxt.FillColor = System.Drawing.Color.Gainsboro;
            this.idtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idtxt.Location = new System.Drawing.Point(135, 135);
            this.idtxt.Name = "idtxt";
            this.idtxt.PasswordChar = '\0';
            this.idtxt.PlaceholderText = "";
            this.idtxt.SelectedText = "";
            this.idtxt.Size = new System.Drawing.Size(200, 36);
            this.idtxt.TabIndex = 1;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // EnterRiderId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(474, 416);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterRiderId";
            this.Text = "EnterRiderId";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox idtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notelbl;
        private Guna.UI2.WinForms.Guna2Button closebtn;
        private Guna.UI2.WinForms.Guna2Button idokbtn;
    }
}
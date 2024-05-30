namespace UberNew.UI.RiderUI
{
    partial class TakeRiderPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeRiderPassword));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showpasscheckbox = new System.Windows.Forms.CheckBox();
            this.loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.showpasscheckbox);
            this.guna2Panel1.Controls.Add(this.loginbtn);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.passxt);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(354, 191);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showpasscheckbox
            // 
            this.showpasscheckbox.AutoSize = true;
            this.showpasscheckbox.ForeColor = System.Drawing.Color.White;
            this.showpasscheckbox.Location = new System.Drawing.Point(176, 107);
            this.showpasscheckbox.Name = "showpasscheckbox";
            this.showpasscheckbox.Size = new System.Drawing.Size(102, 17);
            this.showpasscheckbox.TabIndex = 58;
            this.showpasscheckbox.Text = "Show Password";
            this.showpasscheckbox.UseVisualStyleBackColor = true;
            this.showpasscheckbox.CheckedChanged += new System.EventHandler(this.showpasscheckbox_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.AutoRoundedCorners = true;
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn.BorderRadius = 16;
            this.loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(189, 130);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.PressedColor = System.Drawing.Color.Gray;
            this.loginbtn.Size = new System.Drawing.Size(72, 34);
            this.loginbtn.TabIndex = 56;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Enter Password";
            // 
            // passxt
            // 
            this.passxt.AutoRoundedCorners = true;
            this.passxt.BorderRadius = 17;
            this.passxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passxt.DefaultText = "";
            this.passxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passxt.Location = new System.Drawing.Point(78, 65);
            this.passxt.Name = "passxt";
            this.passxt.PasswordChar = '\0';
            this.passxt.PlaceholderText = "Enter Password";
            this.passxt.SelectedText = "";
            this.passxt.Size = new System.Drawing.Size(200, 36);
            this.passxt.TabIndex = 54;
            this.passxt.TextChanged += new System.EventHandler(this.passxt_TextChanged);
            // 
            // TakeRiderPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TakeRiderPassword";
            this.Size = new System.Drawing.Size(354, 191);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button loginbtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox passxt;
        private System.Windows.Forms.CheckBox showpasscheckbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

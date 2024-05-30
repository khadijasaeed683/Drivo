namespace UberNew.UI.DriverUI
{
    partial class AcceptRide
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
            this.confirmRideAcceptpnl = new Guna.UI2.WinForms.Guna2Panel();
            this.cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.arrivalmincombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2Button();
            this.cnfrmbtn = new Guna.UI2.WinForms.Guna2Button();
            this.notelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmRideAcceptpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmRideAcceptpnl
            // 
            this.confirmRideAcceptpnl.Controls.Add(this.cancelbtn);
            this.confirmRideAcceptpnl.Controls.Add(this.label1);
            this.confirmRideAcceptpnl.Controls.Add(this.arrivalmincombo);
            this.confirmRideAcceptpnl.Controls.Add(this.closebtn);
            this.confirmRideAcceptpnl.Controls.Add(this.cnfrmbtn);
            this.confirmRideAcceptpnl.Controls.Add(this.notelbl);
            this.confirmRideAcceptpnl.Controls.Add(this.label3);
            this.confirmRideAcceptpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmRideAcceptpnl.Location = new System.Drawing.Point(0, 0);
            this.confirmRideAcceptpnl.Name = "confirmRideAcceptpnl";
            this.confirmRideAcceptpnl.Size = new System.Drawing.Size(545, 430);
            this.confirmRideAcceptpnl.TabIndex = 2;
            this.confirmRideAcceptpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.confirmRideAcceptpnl_Paint);
            // 
            // cancelbtn
            // 
            this.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbtn.FillColor = System.Drawing.Color.Maroon;
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(274, 255);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(97, 37);
            this.cancelbtn.TabIndex = 111;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 110;
            this.label1.Text = "Minutes";
            // 
            // arrivalmincombo
            // 
            this.arrivalmincombo.BackColor = System.Drawing.Color.Transparent;
            this.arrivalmincombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.arrivalmincombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalmincombo.FillColor = System.Drawing.Color.DimGray;
            this.arrivalmincombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.arrivalmincombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.arrivalmincombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.arrivalmincombo.ForeColor = System.Drawing.Color.White;
            this.arrivalmincombo.ItemHeight = 30;
            this.arrivalmincombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.arrivalmincombo.Location = new System.Drawing.Point(157, 187);
            this.arrivalmincombo.Name = "arrivalmincombo";
            this.arrivalmincombo.Size = new System.Drawing.Size(140, 36);
            this.arrivalmincombo.TabIndex = 109;
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
            this.closebtn.Location = new System.Drawing.Point(459, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(59, 27);
            this.closebtn.TabIndex = 108;
            this.closebtn.Text = "Close";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // cnfrmbtn
            // 
            this.cnfrmbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfrmbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfrmbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfrmbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfrmbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.cnfrmbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnfrmbtn.ForeColor = System.Drawing.Color.White;
            this.cnfrmbtn.Location = new System.Drawing.Point(135, 255);
            this.cnfrmbtn.Name = "cnfrmbtn";
            this.cnfrmbtn.Size = new System.Drawing.Size(107, 37);
            this.cnfrmbtn.TabIndex = 107;
            this.cnfrmbtn.Text = "Confirm";
            this.cnfrmbtn.Click += new System.EventHandler(this.cnfrmbtn_Click);
            // 
            // notelbl
            // 
            this.notelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notelbl.AutoSize = true;
            this.notelbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelbl.ForeColor = System.Drawing.Color.White;
            this.notelbl.Location = new System.Drawing.Point(110, 66);
            this.notelbl.Name = "notelbl";
            this.notelbl.Size = new System.Drawing.Size(308, 40);
            this.notelbl.TabIndex = 106;
            this.notelbl.Text = "Note: Select the minutes in which you are \r\narriving at the Pickup Location.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 105;
            this.label3.Text = "Arrival In";
            // 
            // AcceptRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(545, 430);
            this.Controls.Add(this.confirmRideAcceptpnl);
            this.Name = "AcceptRide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcceptRide";
            this.confirmRideAcceptpnl.ResumeLayout(false);
            this.confirmRideAcceptpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel confirmRideAcceptpnl;
        private Guna.UI2.WinForms.Guna2Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox arrivalmincombo;
        private Guna.UI2.WinForms.Guna2Button closebtn;
        private Guna.UI2.WinForms.Guna2Button cnfrmbtn;
        private System.Windows.Forms.Label notelbl;
        private System.Windows.Forms.Label label3;
    }
}
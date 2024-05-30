namespace UberNew.UI.RiderUI
{
    partial class RiderRideHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rideshistorygrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Ride_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rideshistorygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.rideshistorygrid);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(640, 494);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 104;
            this.label3.Text = "Rides History";
            // 
            // rideshistorygrid
            // 
            this.rideshistorygrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.rideshistorygrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rideshistorygrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rideshistorygrid.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rideshistorygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rideshistorygrid.ColumnHeadersHeight = 15;
            this.rideshistorygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.rideshistorygrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ride_Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Rating});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rideshistorygrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.rideshistorygrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.rideshistorygrid.Location = new System.Drawing.Point(12, 85);
            this.rideshistorygrid.Name = "rideshistorygrid";
            this.rideshistorygrid.RowHeadersVisible = false;
            this.rideshistorygrid.Size = new System.Drawing.Size(616, 397);
            this.rideshistorygrid.TabIndex = 0;
            this.rideshistorygrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.rideshistorygrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.rideshistorygrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.rideshistorygrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.rideshistorygrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.rideshistorygrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.rideshistorygrid.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.rideshistorygrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.rideshistorygrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.rideshistorygrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rideshistorygrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideshistorygrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.rideshistorygrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.rideshistorygrid.ThemeStyle.HeaderStyle.Height = 15;
            this.rideshistorygrid.ThemeStyle.ReadOnly = false;
            this.rideshistorygrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rideshistorygrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rideshistorygrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideshistorygrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.rideshistorygrid.ThemeStyle.RowsStyle.Height = 22;
            this.rideshistorygrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.rideshistorygrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.rideshistorygrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rideshistorygrid_CellContentClick);
            // 
            // Ride_Id
            // 
            this.Ride_Id.HeaderText = "Ride_id";
            this.Ride_Id.Name = "Ride_Id";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 127.4268F;
            this.Column1.HeaderText = "PickUp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 111.6944F;
            this.Column2.HeaderText = "DropOff";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 111.6944F;
            this.Column3.HeaderText = "Driver Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 111.6944F;
            this.Column4.HeaderText = "Driver Phone No";
            this.Column4.Name = "Column4";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Give Rating";
            this.Rating.Name = "Rating";
            this.Rating.Text = "Rate";
            // 
            // RiderRideHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 494);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RiderRideHistory";
            this.Text = "RiderRideHistory";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rideshistorygrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView rideshistorygrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ride_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Rating;
    }
}
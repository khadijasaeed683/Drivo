namespace UberNew.UI.DriverUI
{
    partial class ActiveRideDriver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewridesgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RideId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOffLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiderPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewridesgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewridesgrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 494);
            this.panel1.TabIndex = 0;
            // 
            // viewridesgrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.viewridesgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewridesgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewridesgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewridesgrid.ColumnHeadersHeight = 15;
            this.viewridesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewridesgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RideId,
            this.PickUpLocation,
            this.DropOffLocation,
            this.Fare,
            this.RiderPhoneNumber,
            this.Completed});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewridesgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewridesgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.viewridesgrid.Location = new System.Drawing.Point(3, 76);
            this.viewridesgrid.Name = "viewridesgrid";
            this.viewridesgrid.RowHeadersVisible = false;
            this.viewridesgrid.Size = new System.Drawing.Size(632, 415);
            this.viewridesgrid.TabIndex = 66;
            this.viewridesgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.viewridesgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.viewridesgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewridesgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewridesgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewridesgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewridesgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewridesgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.viewridesgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.viewridesgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewridesgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewridesgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewridesgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewridesgrid.ThemeStyle.HeaderStyle.Height = 15;
            this.viewridesgrid.ThemeStyle.ReadOnly = false;
            this.viewridesgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.viewridesgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewridesgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewridesgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.viewridesgrid.ThemeStyle.RowsStyle.Height = 22;
            this.viewridesgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.viewridesgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.viewridesgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewridesgrid_CellContentClick);
            // 
            // RideId
            // 
            this.RideId.HeaderText = "Ride ID";
            this.RideId.Name = "RideId";
            // 
            // PickUpLocation
            // 
            this.PickUpLocation.HeaderText = "PickUp Location";
            this.PickUpLocation.Name = "PickUpLocation";
            this.PickUpLocation.ReadOnly = true;
            // 
            // DropOffLocation
            // 
            this.DropOffLocation.HeaderText = "DropOff Location";
            this.DropOffLocation.Name = "DropOffLocation";
            this.DropOffLocation.ReadOnly = true;
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            this.Fare.ReadOnly = true;
            // 
            // RiderPhoneNumber
            // 
            this.RiderPhoneNumber.HeaderText = "Rider Phone Number";
            this.RiderPhoneNumber.Name = "RiderPhoneNumber";
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            this.Completed.Text = "Completed";
            // 
            // ActiveRideDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 494);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ActiveRideDriver";
            this.Text = "ActiveRideDriver";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewridesgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView viewridesgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RideId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOffLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiderPhoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Completed;
    }
}
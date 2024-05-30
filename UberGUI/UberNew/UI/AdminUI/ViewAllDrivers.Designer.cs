namespace UberNew.UI.AdminUI
{
    partial class ViewAllDrivers
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewallridersgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RiderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRider = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewallridersgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.viewallridersgrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 565);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 87;
            this.label1.Text = "All Drivers Information";
            // 
            // viewallridersgrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.viewallridersgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewallridersgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewallridersgrid.ColumnHeadersHeight = 15;
            this.viewallridersgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewallridersgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RiderName,
            this.PhoneNumber,
            this.Id,
            this.JoiningDate,
            this.DeleteRider});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewallridersgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewallridersgrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewallridersgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.viewallridersgrid.Location = new System.Drawing.Point(0, 119);
            this.viewallridersgrid.Name = "viewallridersgrid";
            this.viewallridersgrid.RowHeadersVisible = false;
            this.viewallridersgrid.Size = new System.Drawing.Size(859, 446);
            this.viewallridersgrid.TabIndex = 86;
            this.viewallridersgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.viewallridersgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.viewallridersgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewallridersgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewallridersgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewallridersgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewallridersgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewallridersgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.viewallridersgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.viewallridersgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewallridersgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallridersgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewallridersgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewallridersgrid.ThemeStyle.HeaderStyle.Height = 15;
            this.viewallridersgrid.ThemeStyle.ReadOnly = false;
            this.viewallridersgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.viewallridersgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewallridersgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallridersgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.viewallridersgrid.ThemeStyle.RowsStyle.Height = 22;
            this.viewallridersgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.viewallridersgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.viewallridersgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewallridersgrid_CellContentClick);
            // 
            // RiderName
            // 
            this.RiderName.FillWeight = 112.3096F;
            this.RiderName.HeaderText = "Name";
            this.RiderName.Name = "RiderName";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.FillWeight = 112.3096F;
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Id
            // 
            this.Id.FillWeight = 112.3096F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // JoiningDate
            // 
            this.JoiningDate.FillWeight = 112.3096F;
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            // 
            // DeleteRider
            // 
            this.DeleteRider.FillWeight = 50.76142F;
            this.DeleteRider.HeaderText = "Delete";
            this.DeleteRider.Name = "DeleteRider";
            this.DeleteRider.Text = "Delete";
            // 
            // ViewAllDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(859, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllDrivers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewallridersgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView viewallridersgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRider;
    }
}
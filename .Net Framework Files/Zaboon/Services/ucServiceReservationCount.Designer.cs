namespace Zaboon
{
    partial class ucServiceReservationCount
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
            this.txtServiceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReservationCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtServiceName
            // 
            this.txtServiceName.BorderRadius = 12;
            this.txtServiceName.BorderThickness = 0;
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.DefaultText = "Service Name";
            this.txtServiceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServiceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.FillColor = System.Drawing.Color.LimeGreen;
            this.txtServiceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServiceName.ForeColor = System.Drawing.Color.White;
            this.txtServiceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Location = new System.Drawing.Point(4, 4);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PlaceholderText = "";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(133, 32);
            this.txtServiceName.TabIndex = 14;
            this.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReservationCount
            // 
            this.txtReservationCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReservationCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtReservationCount.BorderRadius = 12;
            this.txtReservationCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReservationCount.DefaultText = "0000";
            this.txtReservationCount.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtReservationCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReservationCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReservationCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReservationCount.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtReservationCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtReservationCount.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtReservationCount.Location = new System.Drawing.Point(145, 4);
            this.txtReservationCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReservationCount.Name = "txtReservationCount";
            this.txtReservationCount.PlaceholderText = "";
            this.txtReservationCount.ReadOnly = true;
            this.txtReservationCount.SelectedText = "";
            this.txtReservationCount.Size = new System.Drawing.Size(297, 32);
            this.txtReservationCount.TabIndex = 15;
            // 
            // ucServiceReservationCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtReservationCount);
            this.Controls.Add(this.txtServiceName);
            this.Name = "ucServiceReservationCount";
            this.Size = new System.Drawing.Size(446, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtServiceName;
        private Guna.UI2.WinForms.Guna2TextBox txtReservationCount;
    }
}

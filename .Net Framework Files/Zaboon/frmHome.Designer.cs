namespace Zaboon
{
    partial class frmHome
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
            this.ucReservationsDashboard1 = new Zaboon.ucReservationsDashboard();
            this.uc_UsersStatistics1 = new Zaboon.ucUsersStatistics();
            this.SuspendLayout();
            // 
            // ucReservationsDashboard1
            // 
            this.ucReservationsDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucReservationsDashboard1.BackColor = System.Drawing.Color.White;
            this.ucReservationsDashboard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucReservationsDashboard1.Location = new System.Drawing.Point(12, 149);
            this.ucReservationsDashboard1.Name = "ucReservationsDashboard1";
            this.ucReservationsDashboard1.Size = new System.Drawing.Size(880, 471);
            this.ucReservationsDashboard1.TabIndex = 2;
            this.ucReservationsDashboard1.TopN = 8;
            // 
            // uc_UsersStatistics1
            // 
            this.uc_UsersStatistics1.Location = new System.Drawing.Point(12, 12);
            this.uc_UsersStatistics1.Name = "uc_UsersStatistics1";
            this.uc_UsersStatistics1.Size = new System.Drawing.Size(898, 139);
            this.uc_UsersStatistics1.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 632);
            this.Controls.Add(this.ucReservationsDashboard1);
            this.Controls.Add(this.uc_UsersStatistics1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ucUsersStatistics uc_UsersStatistics1;
        private ucReservationsDashboard ucReservationsDashboard1;
    }
}
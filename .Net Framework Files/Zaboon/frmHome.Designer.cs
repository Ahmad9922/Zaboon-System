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
            this.ucEmployeesDashboard1 = new Zaboon.ucEmployeesDashboard();
            this.ucClientsDashboard1 = new Zaboon.ucClientsDashboard();
            this.ucQueueDashboard1 = new Zaboon.ucQueueDashboard();
            this.SuspendLayout();
            // 
            // ucEmployeesDashboard1
            // 
            this.ucEmployeesDashboard1.Location = new System.Drawing.Point(324, 12);
            this.ucEmployeesDashboard1.Name = "ucEmployeesDashboard1";
            this.ucEmployeesDashboard1.Size = new System.Drawing.Size(306, 65);
            this.ucEmployeesDashboard1.TabIndex = 1;
            // 
            // ucClientsDashboard1
            // 
            this.ucClientsDashboard1.BackColor = System.Drawing.SystemColors.Control;
            this.ucClientsDashboard1.Location = new System.Drawing.Point(12, 12);
            this.ucClientsDashboard1.Name = "ucClientsDashboard1";
            this.ucClientsDashboard1.Size = new System.Drawing.Size(306, 65);
            this.ucClientsDashboard1.TabIndex = 0;
            // 
            // ucQueueDashboard1
            // 
            this.ucQueueDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ucQueueDashboard1.Location = new System.Drawing.Point(12, 83);
            this.ucQueueDashboard1.Name = "ucQueueDashboard1";
            this.ucQueueDashboard1.Size = new System.Drawing.Size(616, 576);
            this.ucQueueDashboard1.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 671);
            this.Controls.Add(this.ucQueueDashboard1);
            this.Controls.Add(this.ucEmployeesDashboard1);
            this.Controls.Add(this.ucClientsDashboard1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private ucClientsDashboard ucClientsDashboard1;
        private ucEmployeesDashboard ucEmployeesDashboard1;
        private ucQueueDashboard ucQueueDashboard1;
    }
}
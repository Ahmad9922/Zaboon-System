namespace Zaboon
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucLoggedIn1 = new CustomControls.UCLoggedIn();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(550, 549);
            this.guna2Panel1.TabIndex = 2;
            // 
            // ucLoggedIn1
            // 
            this.ucLoggedIn1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucLoggedIn1.Attempts = null;
            this.ucLoggedIn1.BackColor = System.Drawing.Color.White;
            this.ucLoggedIn1.HidePassword = true;
            this.ucLoggedIn1.Location = new System.Drawing.Point(629, 81);
            this.ucLoggedIn1.LoginButtonEnabled = true;
            this.ucLoggedIn1.Name = "ucLoggedIn1";
            this.ucLoggedIn1.Size = new System.Drawing.Size(206, 366);
            this.ucLoggedIn1.TabIndex = 0;
            this.ucLoggedIn1.Theme = System.Drawing.Color.LimeGreen;
            this.ucLoggedIn1.LoginValidation += new System.Func<object, CustomControls.UCLoggedIn.LoginInfoEventArgs, bool>(this.ucLoggedIn1_LoginValidation);
            this.ucLoggedIn1.LoginButtonClick += new System.EventHandler<CustomControls.UCLoggedIn.LoginInfoEventArgs>(this.ucLoggedIn1_LoginButtonClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 549);
            this.Controls.Add(this.ucLoggedIn1);
            this.Controls.Add(this.guna2Panel1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.UCLoggedIn ucLoggedIn1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
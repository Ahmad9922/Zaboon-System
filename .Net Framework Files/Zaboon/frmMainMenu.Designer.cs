namespace Zaboon
{
    partial class frmMainMenu
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cpbAccountImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ucTabControl = new CustomControls.UCTabControl();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cpbAccountImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // cpbAccountImage
            // 
            this.cpbAccountImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cpbAccountImage.BackColor = System.Drawing.Color.Transparent;
            this.cpbAccountImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbAccountImage.Image = global::Zaboon.Properties.Resources.account_circle;
            this.cpbAccountImage.ImageRotate = 0F;
            this.cpbAccountImage.Location = new System.Drawing.Point(11, 10);
            this.cpbAccountImage.Name = "cpbAccountImage";
            this.cpbAccountImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbAccountImage.Size = new System.Drawing.Size(40, 40);
            this.cpbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpbAccountImage.TabIndex = 1;
            this.cpbAccountImage.TabStop = false;
            this.cpbAccountImage.UseTransparentBackground = true;
            this.cpbAccountImage.Click += new System.EventHandler(this.cpbAccountImage_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserName.Location = new System.Drawing.Point(57, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 40);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTabControl
            // 
            this.ucTabControl.BackColor = System.Drawing.Color.White;
            this.ucTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl.Name = "ucTabControl";
            this.ucTabControl.Size = new System.Drawing.Size(1100, 674);
            this.ucTabControl.TabIndex = 0;
            // 
            // 
            // 
            this.ucTabControl.TabProperties.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ucTabControl.TabProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl.TabProperties.ItemSize = new System.Drawing.Size(190, 50);
            this.ucTabControl.TabProperties.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl.TabProperties.Name = "guna2TabControl1";
            this.ucTabControl.TabProperties.Size = new System.Drawing.Size(1091, 674);
            this.ucTabControl.TabProperties.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.ucTabControl.TabProperties.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonHoverState.ForeColor = System.Drawing.Color.SeaGreen;
            this.ucTabControl.TabProperties.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ucTabControl.TabProperties.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonIdleState.ForeColor = System.Drawing.Color.SeaGreen;
            this.ucTabControl.TabProperties.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonSelectedState.ForeColor = System.Drawing.Color.SeaGreen;
            this.ucTabControl.TabProperties.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.ucTabControl.TabProperties.TabButtonSize = new System.Drawing.Size(190, 50);
            this.ucTabControl.TabProperties.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ucTabControl.TabProperties.TabIndex = 0;
            this.ucTabControl.TabProperties.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.cpbAccountImage);
            this.guna2Panel1.Controls.Add(this.lblUserName);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 603);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(167, 59);
            this.guna2Panel1.TabIndex = 3;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 674);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ucTabControl);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpbAccountImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UCTabControl ucTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbAccountImage;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}


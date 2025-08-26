namespace Zaboon
{
    partial class ucUserInfoPanel3
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
            this.pbAccountImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtReservations = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpReservations = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoUserMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAccountImage
            // 
            this.pbAccountImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAccountImage.Image = global::Zaboon.Properties.Resources.account_circle1;
            this.pbAccountImage.ImageRotate = 0F;
            this.pbAccountImage.Location = new System.Drawing.Point(19, 19);
            this.pbAccountImage.Name = "pbAccountImage";
            this.pbAccountImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAccountImage.Size = new System.Drawing.Size(73, 69);
            this.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccountImage.TabIndex = 0;
            this.pbAccountImage.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.BorderRadius = 12;
            this.txtUserName.BorderThickness = 0;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "User Name";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Location = new System.Drawing.Point(99, 52);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(336, 36);
            this.txtUserName.TabIndex = 3;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.txtReservations);
            this.guna2ShadowPanel1.Controls.Add(this.flpReservations);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserName);
            this.guna2ShadowPanel1.Controls.Add(this.pbAccountImage);
            this.guna2ShadowPanel1.Controls.Add(this.lblNoUserMessage);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 20;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(453, 384);
            this.guna2ShadowPanel1.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(19, 94);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(416, 17);
            this.guna2Separator1.TabIndex = 16;
            // 
            // txtReservations
            // 
            this.txtReservations.BorderRadius = 12;
            this.txtReservations.BorderThickness = 0;
            this.txtReservations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReservations.DefaultText = "Reservations";
            this.txtReservations.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReservations.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReservations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReservations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReservations.ForeColor = System.Drawing.Color.Gray;
            this.txtReservations.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReservations.Location = new System.Drawing.Point(19, 117);
            this.txtReservations.Name = "txtReservations";
            this.txtReservations.PlaceholderText = "";
            this.txtReservations.ReadOnly = true;
            this.txtReservations.SelectedText = "";
            this.txtReservations.Size = new System.Drawing.Size(118, 29);
            this.txtReservations.TabIndex = 15;
            // 
            // flpReservations
            // 
            this.flpReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpReservations.AutoScroll = true;
            this.flpReservations.BackColor = System.Drawing.Color.White;
            this.flpReservations.Location = new System.Drawing.Point(19, 152);
            this.flpReservations.Name = "flpReservations";
            this.flpReservations.Size = new System.Drawing.Size(416, 215);
            this.flpReservations.TabIndex = 4;
            // 
            // lblNoUserMessage
            // 
            this.lblNoUserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoUserMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblNoUserMessage.Location = new System.Drawing.Point(19, 19);
            this.lblNoUserMessage.Name = "lblNoUserMessage";
            this.lblNoUserMessage.Size = new System.Drawing.Size(416, 348);
            this.lblNoUserMessage.TabIndex = 0;
            this.lblNoUserMessage.Text = "label1";
            this.lblNoUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoUserMessage.Visible = false;
            // 
            // ucUserInfoPanel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucUserInfoPanel3";
            this.Size = new System.Drawing.Size(453, 384);
            this.Load += new System.EventHandler(this.ucUserInfoPanel3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAccountImage;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpReservations;
        private Guna.UI2.WinForms.Guna2TextBox txtReservations;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblNoUserMessage;
    }
}

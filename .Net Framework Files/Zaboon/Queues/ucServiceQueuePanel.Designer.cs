namespace Zaboon
{
    partial class ucServiceQueuePanel
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
            this.btnQueueManagement = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.txtQueueLength = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtServiceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtServiceHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQueueManagement
            // 
            this.btnQueueManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueueManagement.AutoRoundedCorners = true;
            this.btnQueueManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnQueueManagement.BorderRadius = 18;
            this.btnQueueManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQueueManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQueueManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQueueManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQueueManagement.FillColor = System.Drawing.Color.LimeGreen;
            this.btnQueueManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQueueManagement.ForeColor = System.Drawing.Color.White;
            this.btnQueueManagement.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnQueueManagement.Image = global::Zaboon.Properties.Resources.wc_240dp_FFFFFF_FILL1_wght400_GRAD0_opsz48;
            this.btnQueueManagement.Location = new System.Drawing.Point(368, 19);
            this.btnQueueManagement.Name = "btnQueueManagement";
            this.btnQueueManagement.Size = new System.Drawing.Size(38, 38);
            this.btnQueueManagement.TabIndex = 12;
            this.btnQueueManagement.Click += new System.EventHandler(this.btnQueueManagement_Click);
            // 
            // txtUserType
            // 
            this.txtUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserType.BorderRadius = 12;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "Queue List";
            this.txtUserType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.FillColor = System.Drawing.Color.LimeGreen;
            this.txtUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserType.ForeColor = System.Drawing.Color.White;
            this.txtUserType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Location = new System.Drawing.Point(16, 19);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.PlaceholderText = "";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.SelectedText = "";
            this.txtUserType.Size = new System.Drawing.Size(301, 38);
            this.txtUserType.TabIndex = 14;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.txtServiceHour);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox3);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddClient);
            this.guna2ShadowPanel1.Controls.Add(this.txtQueueLength);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox4);
            this.guna2ShadowPanel1.Controls.Add(this.txtServiceName);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox1);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserType);
            this.guna2ShadowPanel1.Controls.Add(this.btnQueueManagement);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 20;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(420, 208);
            this.guna2ShadowPanel1.TabIndex = 16;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.AutoRoundedCorners = true;
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.BorderRadius = 18;
            this.btnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClient.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAddClient.Location = new System.Drawing.Point(324, 19);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(38, 38);
            this.btnAddClient.TabIndex = 39;
            this.btnAddClient.Text = "➕";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtQueueLength
            // 
            this.txtQueueLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueueLength.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtQueueLength.BorderRadius = 12;
            this.txtQueueLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueueLength.DefaultText = "";
            this.txtQueueLength.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtQueueLength.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQueueLength.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQueueLength.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQueueLength.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtQueueLength.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQueueLength.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtQueueLength.Location = new System.Drawing.Point(121, 157);
            this.txtQueueLength.Name = "txtQueueLength";
            this.txtQueueLength.PlaceholderText = "";
            this.txtQueueLength.ReadOnly = true;
            this.txtQueueLength.SelectedText = "";
            this.txtQueueLength.Size = new System.Drawing.Size(285, 36);
            this.txtQueueLength.TabIndex = 38;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.BorderRadius = 12;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Queue Length";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.Location = new System.Drawing.Point(16, 157);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(99, 36);
            this.guna2TextBox4.TabIndex = 37;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceName.BorderRadius = 12;
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.DefaultText = "";
            this.txtServiceName.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceName.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceName.Location = new System.Drawing.Point(121, 115);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PlaceholderText = "";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(285, 36);
            this.txtServiceName.TabIndex = 36;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Service";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.Location = new System.Drawing.Point(16, 115);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(99, 36);
            this.guna2TextBox1.TabIndex = 35;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServiceHour
            // 
            this.txtServiceHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceHour.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceHour.BorderRadius = 12;
            this.txtServiceHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceHour.DefaultText = "";
            this.txtServiceHour.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceHour.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceHour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceHour.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtServiceHour.Location = new System.Drawing.Point(121, 73);
            this.txtServiceHour.Name = "txtServiceHour";
            this.txtServiceHour.PlaceholderText = "";
            this.txtServiceHour.ReadOnly = true;
            this.txtServiceHour.SelectedText = "";
            this.txtServiceHour.Size = new System.Drawing.Size(285, 36);
            this.txtServiceHour.TabIndex = 41;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.BorderRadius = 12;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "Service Hour";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.Location = new System.Drawing.Point(16, 73);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(99, 36);
            this.guna2TextBox3.TabIndex = 40;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucServiceQueuePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucServiceQueuePanel";
            this.Size = new System.Drawing.Size(420, 208);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnQueueManagement;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtQueueLength;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox txtServiceName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2TextBox txtServiceHour;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}

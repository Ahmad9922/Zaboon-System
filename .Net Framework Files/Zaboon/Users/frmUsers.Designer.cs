namespace Zaboon
{
    partial class frmUsers
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
            this.flpAccountsList = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSwitchType = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucEmployeeType = new Zaboon.ucUserTypeInfo();
            this.ucClientUserType = new Zaboon.ucUserTypeInfo();
            this.SuspendLayout();
            // 
            // flpAccountsList
            // 
            this.flpAccountsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAccountsList.AutoScroll = true;
            this.flpAccountsList.BackColor = System.Drawing.Color.White;
            this.flpAccountsList.Location = new System.Drawing.Point(13, 60);
            this.flpAccountsList.Name = "flpAccountsList";
            this.flpAccountsList.Size = new System.Drawing.Size(908, 443);
            this.flpAccountsList.TabIndex = 1;
            // 
            // txtUserType
            // 
            this.txtUserType.BorderRadius = 12;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "Clients accounts";
            this.txtUserType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.FillColor = System.Drawing.Color.SeaGreen;
            this.txtUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserType.ForeColor = System.Drawing.Color.White;
            this.txtUserType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Location = new System.Drawing.Point(13, 13);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.PlaceholderText = "";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.SelectedText = "";
            this.txtUserType.Size = new System.Drawing.Size(166, 36);
            this.txtUserType.TabIndex = 12;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BorderRadius = 12;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::Zaboon.Properties.Resources.Add;
            this.btnAddUser.Location = new System.Drawing.Point(814, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(107, 36);
            this.btnAddUser.TabIndex = 17;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.BorderRadius = 12;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::Zaboon.Properties.Resources.Search;
            this.txtSearch.Location = new System.Drawing.Point(186, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "User Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(370, 36);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSwitchType
            // 
            this.btnSwitchType.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchType.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSwitchType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwitchType.ForeColor = System.Drawing.Color.White;
            this.btnSwitchType.Image = global::Zaboon.Properties.Resources.Sync;
            this.btnSwitchType.Location = new System.Drawing.Point(562, 13);
            this.btnSwitchType.Name = "btnSwitchType";
            this.btnSwitchType.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnSwitchType.ShadowDecoration.Enabled = true;
            this.btnSwitchType.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSwitchType.Size = new System.Drawing.Size(36, 36);
            this.btnSwitchType.TabIndex = 5;
            this.btnSwitchType.Click += new System.EventHandler(this.btnSwitchType_Click);
            // 
            // ucEmployeeType
            // 
            this.ucEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucEmployeeType.Location = new System.Drawing.Point(345, 509);
            this.ucEmployeeType.Name = "ucEmployeeType";
            this.ucEmployeeType.Size = new System.Drawing.Size(336, 111);
            this.ucEmployeeType.TabIndex = 15;
            this.ucEmployeeType.UserType = null;
            this.ucEmployeeType.EditClosed += new System.EventHandler(this.UserTypeInfo_EditClosed);
            // 
            // ucClientUserType
            // 
            this.ucClientUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucClientUserType.Location = new System.Drawing.Point(12, 509);
            this.ucClientUserType.Name = "ucClientUserType";
            this.ucClientUserType.Size = new System.Drawing.Size(336, 111);
            this.ucClientUserType.TabIndex = 14;
            this.ucClientUserType.UserType = null;
            this.ucClientUserType.EditClosed += new System.EventHandler(this.UserTypeInfo_EditClosed);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 632);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.ucEmployeeType);
            this.Controls.Add(this.ucClientUserType);
            this.Controls.Add(this.flpAccountsList);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSwitchType);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpAccountsList;
        private Guna.UI2.WinForms.Guna2CircleButton btnSwitchType;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private ucUserTypeInfo ucClientUserType;
        private ucUserTypeInfo ucEmployeeType;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
    }
}
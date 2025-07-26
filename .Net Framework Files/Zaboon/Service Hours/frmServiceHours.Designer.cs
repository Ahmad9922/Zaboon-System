namespace Zaboon
{
    partial class frmServiceHours
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
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpServiceHoursList = new System.Windows.Forms.FlowLayoutPanel();
            this.cbDaysOfWeek = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmptyMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserType
            // 
            this.txtUserType.BorderRadius = 12;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "Service Hours";
            this.txtUserType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.FillColor = System.Drawing.Color.LimeGreen;
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
            this.txtUserType.TabIndex = 19;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpServiceHoursList
            // 
            this.flpServiceHoursList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpServiceHoursList.AutoScroll = true;
            this.flpServiceHoursList.BackColor = System.Drawing.Color.White;
            this.flpServiceHoursList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpServiceHoursList.Location = new System.Drawing.Point(13, 56);
            this.flpServiceHoursList.Name = "flpServiceHoursList";
            this.flpServiceHoursList.Size = new System.Drawing.Size(655, 528);
            this.flpServiceHoursList.TabIndex = 21;
            this.flpServiceHoursList.WrapContents = false;
            this.flpServiceHoursList.SizeChanged += new System.EventHandler(this.flpServiceHoursList_SizeChanged);
            // 
            // cbDaysOfWeek
            // 
            this.cbDaysOfWeek.BackColor = System.Drawing.Color.Transparent;
            this.cbDaysOfWeek.BorderRadius = 12;
            this.cbDaysOfWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDaysOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaysOfWeek.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDaysOfWeek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDaysOfWeek.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDaysOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDaysOfWeek.ItemHeight = 30;
            this.cbDaysOfWeek.Items.AddRange(new object[] {
            "All",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cbDaysOfWeek.Location = new System.Drawing.Point(186, 13);
            this.cbDaysOfWeek.Name = "cbDaysOfWeek";
            this.cbDaysOfWeek.Size = new System.Drawing.Size(323, 36);
            this.cbDaysOfWeek.TabIndex = 22;
            this.cbDaysOfWeek.SelectedIndexChanged += new System.EventHandler(this.cbDaysOfWeek_SelectedIndexChanged);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.BorderRadius = 12;
            this.btnAddService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddService.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Image = global::Zaboon.Properties.Resources.Add;
            this.btnAddService.Location = new System.Drawing.Point(568, 13);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(100, 36);
            this.btnAddService.TabIndex = 20;
            this.btnAddService.Text = "Add";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmptyMessage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmptyMessage.Location = new System.Drawing.Point(13, 53);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(655, 531);
            this.lblEmptyMessage.TabIndex = 0;
            this.lblEmptyMessage.Text = "Service hours have not been set yet.";
            this.lblEmptyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmServiceHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 596);
            this.Controls.Add(this.cbDaysOfWeek);
            this.Controls.Add(this.flpServiceHoursList);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.lblEmptyMessage);
            this.MinimumSize = new System.Drawing.Size(644, 458);
            this.Name = "frmServiceHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Hours";
            this.Load += new System.EventHandler(this.frmServiceHours_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private System.Windows.Forms.FlowLayoutPanel flpServiceHoursList;
        private Guna.UI2.WinForms.Guna2ComboBox cbDaysOfWeek;
        private System.Windows.Forms.Label lblEmptyMessage;
    }
}
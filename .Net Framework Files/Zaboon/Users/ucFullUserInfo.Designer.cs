namespace Zaboon
{
    partial class ucFullUserInfo
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.btnPermissions = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPassword = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreateDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pbAccountImage = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.BorderColor = System.Drawing.Color.White;
            this.guna2ShapesTool1.BorderThickness = 48;
            this.guna2ShapesTool1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShapesTool1.Location = new System.Drawing.Point(-32, -34);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(190, 190);
            this.guna2ShapesTool1.TargetControl = this.pbAccountImage;
            // 
            // btnPermissions
            // 
            this.btnPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermissions.BorderRadius = 12;
            this.btnPermissions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPermissions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPermissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPermissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPermissions.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPermissions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPermissions.ForeColor = System.Drawing.Color.White;
            this.btnPermissions.Location = new System.Drawing.Point(303, 3);
            this.btnPermissions.Name = "btnPermissions";
            this.btnPermissions.Size = new System.Drawing.Size(199, 36);
            this.btnPermissions.TabIndex = 8;
            this.btnPermissions.Text = "Permissions";
            this.btnPermissions.Visible = false;
            this.btnPermissions.Click += new System.EventHandler(this.btnShowPermissions_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.BorderRadius = 12;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.Location = new System.Drawing.Point(242, 78);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(273, 36);
            this.txtUserName.TabIndex = 2;
            // 
            // txtUserType
            // 
            this.txtUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserType.BorderRadius = 18;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "";
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
            this.txtUserType.Size = new System.Drawing.Size(502, 58);
            this.txtUserType.TabIndex = 11;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.btnEdit);
            this.guna2ShadowPanel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox5);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox4);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox3);
            this.guna2ShadowPanel1.Controls.Add(this.txtEmail);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.txtPhone);
            this.guna2ShadowPanel1.Controls.Add(this.pbAccountImage);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserName);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserType);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 60;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(528, 346);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSelectImage);
            this.flowLayoutPanel1.Controls.Add(this.btnPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnPermissions);
            this.flowLayoutPanel1.Controls.Add(this.guna2TextBox6);
            this.flowLayoutPanel1.Controls.Add(this.txtCreateDate);
            this.flowLayoutPanel1.Controls.Add(this.cbIsActive);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 204);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(512, 114);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassword.BorderRadius = 12;
            this.btnPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassword.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Location = new System.Drawing.Point(129, 3);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(168, 36);
            this.btnPassword.TabIndex = 21;
            this.btnPassword.Text = "Password";
            this.btnPassword.Visible = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox6.BorderRadius = 12;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "Create Date";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox6.Location = new System.Drawing.Point(3, 45);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.ReadOnly = true;
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(97, 36);
            this.guna2TextBox6.TabIndex = 29;
            this.guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreateDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCreateDate.BorderRadius = 12;
            this.txtCreateDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateDate.DefaultText = "";
            this.txtCreateDate.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCreateDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreateDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateDate.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCreateDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreateDate.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCreateDate.Location = new System.Drawing.Point(106, 45);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.PlaceholderText = "";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.SelectedText = "";
            this.txtCreateDate.Size = new System.Drawing.Size(396, 36);
            this.txtCreateDate.TabIndex = 30;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Checked = true;
            this.cbIsActive.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.cbIsActive.CheckedState.BorderRadius = 0;
            this.cbIsActive.CheckedState.BorderThickness = 0;
            this.cbIsActive.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbIsActive.Location = new System.Drawing.Point(3, 87);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(78, 21);
            this.cbIsActive.TabIndex = 14;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsActive.UncheckedState.BorderRadius = 0;
            this.cbIsActive.UncheckedState.BorderThickness = 0;
            this.cbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbIsActive.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox5.BorderRadius = 12;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "Email";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox5.Location = new System.Drawing.Point(139, 162);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.ReadOnly = true;
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(97, 36);
            this.guna2TextBox5.TabIndex = 28;
            this.guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.BorderRadius = 12;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Phone";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox4.Location = new System.Drawing.Point(139, 120);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(97, 36);
            this.guna2TextBox4.TabIndex = 27;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.BorderRadius = 12;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "User Name";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox3.Location = new System.Drawing.Point(139, 78);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(97, 36);
            this.guna2TextBox3.TabIndex = 26;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(242, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(273, 36);
            this.txtEmail.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.BorderRadius = 12;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(242, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(273, 36);
            this.txtPhone.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 12;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Zaboon.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(393, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Zaboon.Properties.Resources.Edit1;
            this.btnEdit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEdit.Location = new System.Drawing.Point(422, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 36);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BorderRadius = 12;
            this.btnSelectImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectImage.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Image = global::Zaboon.Properties.Resources.add_photo_alternate;
            this.btnSelectImage.Location = new System.Drawing.Point(3, 3);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(120, 36);
            this.btnSelectImage.TabIndex = 18;
            this.btnSelectImage.Visible = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Zaboon.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbAccountImage
            // 
            this.pbAccountImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAccountImage.Image = global::Zaboon.Properties.Resources.account_circle1;
            this.pbAccountImage.Location = new System.Drawing.Point(13, 78);
            this.pbAccountImage.Name = "pbAccountImage";
            this.pbAccountImage.Size = new System.Drawing.Size(120, 120);
            this.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccountImage.TabIndex = 6;
            this.pbAccountImage.TabStop = false;
            // 
            // ucFullUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucFullUserInfo";
            this.Size = new System.Drawing.Size(528, 346);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private System.Windows.Forms.PictureBox pbAccountImage;
        private Guna.UI2.WinForms.Guna2Button btnPermissions;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CheckBox cbIsActive;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnSelectImage;
        private Guna.UI2.WinForms.Guna2Button btnPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtCreateDate;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

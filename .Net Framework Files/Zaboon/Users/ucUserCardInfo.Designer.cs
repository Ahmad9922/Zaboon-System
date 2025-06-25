namespace Zaboon
{
    partial class ucUserCardInfo
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
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pbAccountImage = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BorderThickness = 0;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(76, 18);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(184, 36);
            this.txtUserName.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pbAccountImage);
            this.guna2ShadowPanel1.Controls.Add(this.txtUserName);
            this.guna2ShadowPanel1.Controls.Add(this.btnDelete);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(334, 67);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // pbAccountImage
            // 
            this.pbAccountImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAccountImage.Image = global::Zaboon.Properties.Resources.account_circle1;
            this.pbAccountImage.Location = new System.Drawing.Point(20, 9);
            this.pbAccountImage.Name = "pbAccountImage";
            this.pbAccountImage.Size = new System.Drawing.Size(50, 50);
            this.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccountImage.TabIndex = 5;
            this.pbAccountImage.TabStop = false;
            this.pbAccountImage.Click += new System.EventHandler(this.pbAccountImage_Click);
            this.pbAccountImage.MouseEnter += new System.EventHandler(this.pbAccountImage_MouseEnter);
            this.pbAccountImage.MouseLeave += new System.EventHandler(this.pbAccountImage_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Zaboon.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(291, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.BorderColor = System.Drawing.Color.White;
            this.guna2ShapesTool1.BorderThickness = 20;
            this.guna2ShapesTool1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShapesTool1.Location = new System.Drawing.Point(-14, -14);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(80, 80);
            this.guna2ShapesTool1.TargetControl = this.pbAccountImage;
            // 
            // ucUserCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucUserCardInfo";
            this.Size = new System.Drawing.Size(334, 67);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox pbAccountImage;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
    }
}

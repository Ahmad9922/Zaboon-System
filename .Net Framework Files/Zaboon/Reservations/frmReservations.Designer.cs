namespace Zaboon
{
    partial class frmReservations
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgReservationsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.btnQueueManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserType
            // 
            this.txtUserType.BorderRadius = 12;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "Reservations";
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
            this.txtUserType.TabIndex = 15;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgReservationsList
            // 
            this.dgReservationsList.AllowUserToAddRows = false;
            this.dgReservationsList.AllowUserToDeleteRows = false;
            this.dgReservationsList.AllowUserToResizeColumns = false;
            this.dgReservationsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgReservationsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservationsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReservationsList.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgReservationsList.ColumnHeadersHeight = 40;
            this.dgReservationsList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservationsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgReservationsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgReservationsList.Location = new System.Drawing.Point(13, 71);
            this.dgReservationsList.MultiSelect = false;
            this.dgReservationsList.Name = "dgReservationsList";
            this.dgReservationsList.ReadOnly = true;
            this.dgReservationsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgReservationsList.RowHeadersVisible = false;
            this.dgReservationsList.RowTemplate.Height = 60;
            this.dgReservationsList.Size = new System.Drawing.Size(908, 549);
            this.dgReservationsList.TabIndex = 17;
            this.dgReservationsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgReservationsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgReservationsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgReservationsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgReservationsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgReservationsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgReservationsList.ThemeStyle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgReservationsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgReservationsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgReservationsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservationsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgReservationsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgReservationsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgReservationsList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgReservationsList.ThemeStyle.ReadOnly = true;
            this.dgReservationsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgReservationsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgReservationsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgReservationsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgReservationsList.ThemeStyle.RowsStyle.Height = 60;
            this.dgReservationsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgReservationsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgReservationsList.SizeChanged += new System.EventHandler(this.dgReservationsList_SizeChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 130);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Zaboon.Properties.Resources.Add_Circle;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 42);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cToolStripMenuItem.Image = global::Zaboon.Properties.Resources.article_person;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.cToolStripMenuItem.Size = new System.Drawing.Size(217, 42);
            this.cToolStripMenuItem.Text = "Show Client Information";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Zaboon.Properties.Resources.Edit2;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(217, 42);
            this.editToolStripMenuItem.Text = "Edit Reservation";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.BorderColor = System.Drawing.Color.White;
            this.guna2ShapesTool1.BorderThickness = 10;
            this.guna2ShapesTool1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShapesTool1.Location = new System.Drawing.Point(-10, -10);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(928, 569);
            this.guna2ShapesTool1.TargetControl = this.dgReservationsList;
            // 
            // btnQueueManagement
            // 
            this.btnQueueManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueueManagement.BorderRadius = 12;
            this.btnQueueManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQueueManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQueueManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQueueManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQueueManagement.FillColor = System.Drawing.Color.LimeGreen;
            this.btnQueueManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQueueManagement.ForeColor = System.Drawing.Color.White;
            this.btnQueueManagement.Image = global::Zaboon.Properties.Resources.event_list;
            this.btnQueueManagement.Location = new System.Drawing.Point(643, 13);
            this.btnQueueManagement.Name = "btnQueueManagement";
            this.btnQueueManagement.Size = new System.Drawing.Size(172, 36);
            this.btnQueueManagement.TabIndex = 21;
            this.btnQueueManagement.Text = "Queue Management";
            this.btnQueueManagement.Click += new System.EventHandler(this.btnQueueManagement_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReservation.BorderRadius = 12;
            this.btnAddReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddReservation.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Image = global::Zaboon.Properties.Resources.Add;
            this.btnAddReservation.Location = new System.Drawing.Point(821, 13);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(100, 36);
            this.btnAddReservation.TabIndex = 19;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 17;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Image = global::Zaboon.Properties.Resources.filter_alt;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(470, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.LimeGreen;
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
            this.txtSearch.Size = new System.Drawing.Size(278, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 16;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Client Image";
            this.dataGridViewImageColumn1.Image = global::Zaboon.Properties.Resources.account_circle1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 454;
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 632);
            this.Controls.Add(this.btnQueueManagement);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgReservationsList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtUserType);
            this.Name = "frmReservations";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAddReservation;
        private Guna.UI2.WinForms.Guna2DataGridView dgReservationsList;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Button btnQueueManagement;
    }
}
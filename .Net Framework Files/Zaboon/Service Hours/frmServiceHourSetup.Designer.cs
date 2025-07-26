namespace Zaboon
{
    partial class frmServiceHourSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceHourSetup));
            CustomControls.UCTimeRangePicker.TimeRange timeRange2 = new CustomControls.UCTimeRangePicker.TimeRange();
            this.ucDayOfWeek = new CustomControls.UCTitle();
            this.ucTitle1 = new CustomControls.UCTitle();
            this.cbDaysOfWeek = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ucTimeRangePicker1 = new CustomControls.UCTimeRangePicker();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ucTitle2 = new CustomControls.UCTitle();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ucDayOfWeek
            // 
            this.ucDayOfWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ucDayOfWeek.BorderThickness = 1;
            this.ucDayOfWeek.BorederRadius = 12;
            this.ucDayOfWeek.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ucDayOfWeek.IconLeft = null;
            this.ucDayOfWeek.IconRight = null;
            resources.ApplyResources(this.ucDayOfWeek, "ucDayOfWeek");
            this.ucDayOfWeek.MultiLine = false;
            this.ucDayOfWeek.Name = "ucDayOfWeek";
            this.ucDayOfWeek.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Default;
            this.ucDayOfWeek.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucDayOfWeek.Title = "Day Of Week";
            // 
            // ucTitle1
            // 
            this.ucTitle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ucTitle1.BorderThickness = 1;
            this.ucTitle1.BorederRadius = 12;
            this.ucTitle1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ucTitle1.IconLeft = null;
            this.ucTitle1.IconRight = null;
            resources.ApplyResources(this.ucTitle1, "ucTitle1");
            this.ucTitle1.MultiLine = false;
            this.ucTitle1.Name = "ucTitle1";
            this.ucTitle1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Default;
            this.ucTitle1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucTitle1.Title = "Day Of Week";
            // 
            // cbDaysOfWeek
            // 
            this.cbDaysOfWeek.BackColor = System.Drawing.Color.Transparent;
            this.cbDaysOfWeek.BorderRadius = 12;
            this.cbDaysOfWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDaysOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaysOfWeek.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDaysOfWeek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbDaysOfWeek, "cbDaysOfWeek");
            this.cbDaysOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDaysOfWeek.Items.AddRange(new object[] {
            resources.GetString("cbDaysOfWeek.Items"),
            resources.GetString("cbDaysOfWeek.Items1"),
            resources.GetString("cbDaysOfWeek.Items2"),
            resources.GetString("cbDaysOfWeek.Items3"),
            resources.GetString("cbDaysOfWeek.Items4"),
            resources.GetString("cbDaysOfWeek.Items5"),
            resources.GetString("cbDaysOfWeek.Items6")});
            this.cbDaysOfWeek.Name = "cbDaysOfWeek";
            // 
            // ucTimeRangePicker1
            // 
            resources.ApplyResources(this.ucTimeRangePicker1, "ucTimeRangePicker1");
            this.ucTimeRangePicker1.Name = "ucTimeRangePicker1";
            timeRange2.EndTime = System.TimeSpan.Parse("00:00:00");
            timeRange2.StartTime = System.TimeSpan.Parse("00:00:00");
            this.ucTimeRangePicker1.Value = timeRange2;
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 12;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Gainsboro;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucTitle2
            // 
            this.ucTitle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ucTitle2.BorderThickness = 1;
            this.ucTitle2.BorederRadius = 12;
            this.ucTitle2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ucTitle2.IconLeft = null;
            this.ucTitle2.IconRight = null;
            resources.ApplyResources(this.ucTitle2, "ucTitle2");
            this.ucTitle2.MultiLine = false;
            this.ucTitle2.Name = "ucTitle2";
            this.ucTitle2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Default;
            this.ucTitle2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucTitle2.Title = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.LightGray;
            this.txtTitle.BorderRadius = 12;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            // 
            // frmServiceHourSetup
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.ucTitle2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ucTimeRangePicker1);
            this.Controls.Add(this.cbDaysOfWeek);
            this.Controls.Add(this.ucTitle1);
            this.Controls.Add(this.ucDayOfWeek);
            this.Name = "frmServiceHourSetup";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.UCTitle ucDayOfWeek;
        private CustomControls.UCTitle ucTitle1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDaysOfWeek;
        private CustomControls.UCTimeRangePicker ucTimeRangePicker1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private CustomControls.UCTitle ucTitle2;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
    }
}
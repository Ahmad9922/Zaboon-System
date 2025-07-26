namespace Zaboon
{
    partial class frmQueueManagement
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
            this.btnServed = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserType = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSkip = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostponeTurn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucUserCardInfo2 = new Zaboon.ucUserCardInfo();
            this.ucUserCardInfo1 = new Zaboon.ucUserCardInfo();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnServed
            // 
            this.btnServed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServed.BorderRadius = 12;
            this.btnServed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServed.FillColor = System.Drawing.Color.LimeGreen;
            this.btnServed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnServed.ForeColor = System.Drawing.Color.White;
            this.btnServed.Location = new System.Drawing.Point(974, 57);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(112, 36);
            this.btnServed.TabIndex = 20;
            this.btnServed.Text = "Served";
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // txtUserType
            // 
            this.txtUserType.BorderRadius = 12;
            this.txtUserType.BorderThickness = 0;
            this.txtUserType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserType.DefaultText = "Clients waiting list";
            this.txtUserType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserType.FillColor = System.Drawing.Color.LimeGreen;
            this.txtUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserType.ForeColor = System.Drawing.Color.White;
            this.txtUserType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserType.Location = new System.Drawing.Point(13, 57);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.PlaceholderText = "";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.SelectedText = "";
            this.txtUserType.Size = new System.Drawing.Size(293, 36);
            this.txtUserType.TabIndex = 21;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 12;
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Next";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(314, 57);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(292, 36);
            this.guna2TextBox2.TabIndex = 24;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.BorderRadius = 12;
            this.btnSkip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkip.FillColor = System.Drawing.Color.Silver;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(742, 57);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(97, 36);
            this.btnSkip.TabIndex = 26;
            this.btnSkip.Text = "Skip";
            // 
            // btnPostponeTurn
            // 
            this.btnPostponeTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPostponeTurn.BorderRadius = 12;
            this.btnPostponeTurn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostponeTurn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostponeTurn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostponeTurn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostponeTurn.FillColor = System.Drawing.Color.Orange;
            this.btnPostponeTurn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostponeTurn.ForeColor = System.Drawing.Color.White;
            this.btnPostponeTurn.Location = new System.Drawing.Point(845, 57);
            this.btnPostponeTurn.Name = "btnPostponeTurn";
            this.btnPostponeTurn.Size = new System.Drawing.Size(123, 36);
            this.btnPostponeTurn.TabIndex = 27;
            this.btnPostponeTurn.Text = "Postpone Turn";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 12;
            this.guna2TextBox3.BorderThickness = 0;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "Service Hour";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(350, 13);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(736, 36);
            this.guna2TextBox3.TabIndex = 30;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderRadius = 12;
            this.guna2TextBox4.BorderThickness = 0;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Number of waiting Client";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(13, 13);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(329, 36);
            this.guna2TextBox4.TabIndex = 32;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucUserCardInfo2
            // 
            this.ucUserCardInfo2.Location = new System.Drawing.Point(314, 100);
            this.ucUserCardInfo2.Name = "ucUserCardInfo2";
            this.ucUserCardInfo2.ShowDeleteButton = false;
            this.ucUserCardInfo2.Size = new System.Drawing.Size(292, 112);
            this.ucUserCardInfo2.TabIndex = 25;
            this.ucUserCardInfo2.User = null;
            // 
            // ucUserCardInfo1
            // 
            this.ucUserCardInfo1.Location = new System.Drawing.Point(13, 100);
            this.ucUserCardInfo1.Name = "ucUserCardInfo1";
            this.ucUserCardInfo1.ShowDeleteButton = false;
            this.ucUserCardInfo1.Size = new System.Drawing.Size(293, 112);
            this.ucUserCardInfo1.TabIndex = 23;
            this.ucUserCardInfo1.User = null;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(613, 56);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(123, 36);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "Postpone Turn";
            // 
            // frmQueueManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 231);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.btnPostponeTurn);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.ucUserCardInfo2);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.ucUserCardInfo1);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.btnServed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmQueueManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnServed;
        private Guna.UI2.WinForms.Guna2TextBox txtUserType;
        private ucUserCardInfo ucUserCardInfo1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private ucUserCardInfo ucUserCardInfo2;
        private Guna.UI2.WinForms.Guna2Button btnSkip;
        private Guna.UI2.WinForms.Guna2Button btnPostponeTurn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
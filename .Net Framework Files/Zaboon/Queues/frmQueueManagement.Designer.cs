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
            this.txtServedClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSkip = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostponeTurn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStart = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucReceivesService = new Zaboon.ucUserInfoPanel();
            this.ucServedClient = new Zaboon.ucUserInfoPanel();
            this.ucNextClient = new Zaboon.ucUserInfoPanel();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServed
            // 
            this.btnServed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnServed.BorderRadius = 12;
            this.btnServed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnServed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnServed.ForeColor = System.Drawing.Color.White;
            this.btnServed.Location = new System.Drawing.Point(145, 412);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(112, 40);
            this.btnServed.TabIndex = 20;
            this.btnServed.Text = "Served";
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // txtServedClient
            // 
            this.txtServedClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtServedClient.BorderRadius = 12;
            this.txtServedClient.BorderThickness = 0;
            this.txtServedClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServedClient.DefaultText = "Last Served Client";
            this.txtServedClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServedClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServedClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServedClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServedClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtServedClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServedClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServedClient.ForeColor = System.Drawing.Color.DarkGray;
            this.txtServedClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServedClient.Location = new System.Drawing.Point(58, 254);
            this.txtServedClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServedClient.Name = "txtServedClient";
            this.txtServedClient.PlaceholderText = "";
            this.txtServedClient.ReadOnly = true;
            this.txtServedClient.SelectedText = "";
            this.txtServedClient.Size = new System.Drawing.Size(149, 112);
            this.txtServedClient.TabIndex = 21;
            this.txtServedClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2TextBox2.BorderRadius = 12;
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Receives service";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(58, 138);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(149, 110);
            this.guna2TextBox2.TabIndex = 24;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSkip.BorderRadius = 12;
            this.btnSkip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkip.FillColor = System.Drawing.Color.DarkGray;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(381, 412);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(112, 40);
            this.btnSkip.TabIndex = 26;
            this.btnSkip.Text = "Skip";
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnPostponeTurn
            // 
            this.btnPostponeTurn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPostponeTurn.BorderRadius = 12;
            this.btnPostponeTurn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostponeTurn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostponeTurn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostponeTurn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostponeTurn.FillColor = System.Drawing.Color.DarkGray;
            this.btnPostponeTurn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostponeTurn.ForeColor = System.Drawing.Color.White;
            this.btnPostponeTurn.Location = new System.Drawing.Point(263, 411);
            this.btnPostponeTurn.Name = "btnPostponeTurn";
            this.btnPostponeTurn.Size = new System.Drawing.Size(112, 40);
            this.btnPostponeTurn.TabIndex = 33;
            this.btnPostponeTurn.Text = "Postpone Turn";
            this.btnPostponeTurn.Click += new System.EventHandler(this.btnPostponeTurn_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Next";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(58, 18);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(149, 112);
            this.guna2TextBox1.TabIndex = 34;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox3.BorderRadius = 12;
            this.guna2TextBox3.BorderThickness = 0;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "Queue Management";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(13, 13);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(642, 49);
            this.guna2TextBox3.TabIndex = 36;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtServedClient);
            this.guna2Panel1.Controls.Add(this.btnPostponeTurn);
            this.guna2Panel1.Controls.Add(this.btnSkip);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.btnServed);
            this.guna2Panel1.Controls.Add(this.ucReceivesService);
            this.guna2Panel1.Controls.Add(this.ucServedClient);
            this.guna2Panel1.Controls.Add(this.guna2TextBox2);
            this.guna2Panel1.Controls.Add(this.ucNextClient);
            this.guna2Panel1.Location = new System.Drawing.Point(13, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(642, 464);
            this.guna2Panel1.TabIndex = 37;
            this.guna2Panel1.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(271, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStart.Size = new System.Drawing.Size(120, 120);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ucReceivesService
            // 
            this.ucReceivesService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucReceivesService.Location = new System.Drawing.Point(214, 136);
            this.ucReceivesService.Name = "ucReceivesService";
            this.ucReceivesService.ShowDeleteButton = false;
            this.ucReceivesService.Size = new System.Drawing.Size(366, 112);
            this.ucReceivesService.TabIndex = 35;
            this.ucReceivesService.User = null;
            // 
            // ucServedClient
            // 
            this.ucServedClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucServedClient.Location = new System.Drawing.Point(214, 254);
            this.ucServedClient.Name = "ucServedClient";
            this.ucServedClient.ShowDeleteButton = false;
            this.ucServedClient.Size = new System.Drawing.Size(366, 112);
            this.ucServedClient.TabIndex = 23;
            this.ucServedClient.User = null;
            // 
            // ucNextClient
            // 
            this.ucNextClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucNextClient.Location = new System.Drawing.Point(214, 18);
            this.ucNextClient.Name = "ucNextClient";
            this.ucNextClient.ShowDeleteButton = false;
            this.ucNextClient.Size = new System.Drawing.Size(366, 112);
            this.ucNextClient.TabIndex = 25;
            this.ucNextClient.User = null;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.AutoRoundedCorners = true;
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BorderRadius = 19;
            this.btnShowAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnShowAll.Image = global::Zaboon.Properties.Resources.visibility1;
            this.btnShowAll.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowAll.Location = new System.Drawing.Point(604, 17);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(40, 40);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.UseTransparentBackground = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmQueueManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 554);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmQueueManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Management";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnServed;
        private Guna.UI2.WinForms.Guna2TextBox txtServedClient;
        private ucUserInfoPanel ucServedClient;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private ucUserInfoPanel ucNextClient;
        private Guna.UI2.WinForms.Guna2Button btnSkip;
        private Guna.UI2.WinForms.Guna2Button btnPostponeTurn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private ucUserInfoPanel ucReceivesService;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnStart;
        private Guna.UI2.WinForms.Guna2Button btnShowAll;
    }
}
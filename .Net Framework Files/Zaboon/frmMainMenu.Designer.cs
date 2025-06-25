namespace Zaboon
{
    partial class frmMainMenu
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
            this.ucTabControl = new CustomControls.UCTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ucTabControl
            // 
            this.ucTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl.Location = new System.Drawing.Point(0, 44);
            this.ucTabControl.Name = "ucTabControl";
            this.ucTabControl.Size = new System.Drawing.Size(1097, 630);
            this.ucTabControl.TabIndex = 0;
            // 
            // 
            // 
            this.ucTabControl.TabProperties.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ucTabControl.TabProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl.TabProperties.ItemSize = new System.Drawing.Size(160, 40);
            this.ucTabControl.TabProperties.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl.TabProperties.Name = "guna2TabControl1";
            this.ucTabControl.TabProperties.Size = new System.Drawing.Size(1097, 641);
            this.ucTabControl.TabProperties.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonHoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ucTabControl.TabProperties.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonHoverState.InnerColor = System.Drawing.Color.Green;
            this.ucTabControl.TabProperties.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.ucTabControl.TabProperties.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonIdleState.InnerColor = System.Drawing.Color.Green;
            this.ucTabControl.TabProperties.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.ucTabControl.TabProperties.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.ucTabControl.TabProperties.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ucTabControl.TabProperties.TabButtonSelectedState.ForeColor = System.Drawing.Color.SeaGreen;
            this.ucTabControl.TabProperties.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.ucTabControl.TabProperties.TabButtonSize = new System.Drawing.Size(160, 40);
            this.ucTabControl.TabProperties.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ucTabControl.TabProperties.TabIndex = 0;
            this.ucTabControl.TabProperties.TabMenuBackColor = System.Drawing.Color.SeaGreen;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 44);
            this.panel1.TabIndex = 0;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 674);
            this.Controls.Add(this.ucTabControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UCTabControl ucTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
    }
}


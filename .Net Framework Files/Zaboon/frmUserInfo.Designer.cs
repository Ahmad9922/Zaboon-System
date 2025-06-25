namespace Zaboon
{
    partial class frmUserInfo
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
            this.ucFullUserInfo1 = new Zaboon.ucFullUserInfo();
            this.SuspendLayout();
            // 
            // ucFullUserInfo1
            // 
            this.ucFullUserInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucFullUserInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ucFullUserInfo1.Location = new System.Drawing.Point(12, 12);
            this.ucFullUserInfo1.Name = "ucFullUserInfo1";
            this.ucFullUserInfo1.Size = new System.Drawing.Size(536, 325);
            this.ucFullUserInfo1.TabIndex = 0;
            this.ucFullUserInfo1.User = null;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 353);
            this.Controls.Add(this.ucFullUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private ucFullUserInfo ucFullUserInfo1;
    }
}
namespace Zaboon
{
    partial class ucFindUser
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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucUserCardInfo1 = new Zaboon.ucUserInfoPanel();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.LimeGreen;
            this.txtSearch.BorderRadius = 12;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
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
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Location = new System.Drawing.Point(10, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "User Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(381, 36);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.IconRightClick += new System.EventHandler(this.txtSearch_IconRightClick);
            this.txtSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSearch_PreviewKeyDown);
            // 
            // ucUserCardInfo1
            // 
            this.ucUserCardInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUserCardInfo1.Location = new System.Drawing.Point(3, 60);
            this.ucUserCardInfo1.Name = "ucUserCardInfo1";
            this.ucUserCardInfo1.ShowDeleteButton = false;
            this.ucUserCardInfo1.Size = new System.Drawing.Size(388, 323);
            this.ucUserCardInfo1.TabIndex = 0;
            this.ucUserCardInfo1.User = null;
            // 
            // ucFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ucUserCardInfo1);
            this.Name = "ucFindUser";
            this.Size = new System.Drawing.Size(601, 386);
            this.ResumeLayout(false);

        }

        #endregion

        private ucUserInfoPanel ucUserCardInfo1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}

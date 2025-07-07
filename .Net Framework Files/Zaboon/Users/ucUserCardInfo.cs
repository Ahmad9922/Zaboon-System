using Dotools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaboonBL;
using static Guna.UI2.Native.WinApi;

namespace Zaboon
{
    public partial class ucUserCardInfo : UserControl
    {
        public event EventHandler UserInfoClosed;

        public event EventHandler OnUserDeleted;

        public clsUser User { get; set; }

        public bool ShowDeleteButton
        {
            get
            {
                return btnDelete.Visible;
            }

            set
            {
                btnDelete.Visible = value;
            }
        }

        public ucUserCardInfo()
        {
            InitializeComponent();
        }

        private void LoadImage()
        {
            try
            {
                if (User.ImageByte != null)
                {
                    pbAccountImage.Image = clsConverter.ToImage(User.ImageByte);
                }
            }
            catch (Exception ex)
            {
                clsEventLogger.WriteEntryInApplicationLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
        }

        private void LoadInfo()
        {
            LoadImage();
            txtUserName.Text = User.UserName;

            if (!User.IsActive)
            {
                guna2ShadowPanel1.FillColor = Color.Silver;
                guna2ShapesTool1.BorderColor = Color.Silver;
                txtUserName.FillColor = Color.Silver;
                txtUserName.ForeColor = Color.White;
            }
            else
            {
                guna2ShadowPanel1.FillColor = Color.White;
                guna2ShapesTool1.BorderColor = Color.White;
                txtUserName.FillColor = Color.White;
                txtUserName.ForeColor = Color.Silver;
            }
        }

        public void FillUser(int UserID)
        {
            if ((User = clsUser.Find(UserID)) != null)
            {
                LoadInfo();
            }
        }

        public void FillUser(clsUser User)
        {
            this.User = User;

            if (User != null)
            {
                LoadInfo();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {User.UserName}",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (User.Delete())
                {
                    MessageBox.Show("The user has been successfully deleted.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();

                    OnUserDeleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("This user cannot be deleted because they are linked to " +
                        "other entities in the system.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbAccountImage_MouseLeave(object sender, EventArgs e)
        {
            guna2ShapesTool1.FillColor = Color.Transparent;
        }

        private void pbAccountImage_MouseEnter(object sender, EventArgs e)
        {
            guna2ShapesTool1.FillColor = Color.Gainsboro;
        }

        private void pbAccountImage_Click(object sender, EventArgs e)
        {
            guna2ShapesTool1.FillColor = Color.Transparent;

            frmUserInfo UserInfo = new frmUserInfo(User);
            UserInfo.ShowDialog();

            LoadInfo();

            UserInfoClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}

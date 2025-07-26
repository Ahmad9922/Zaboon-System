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

namespace Zaboon
{
    public partial class ucUserCardInfo : UserControl
    {
        public event EventHandler UserInfoClosed;

        public event EventHandler OnUserDeleted;

        public clsUser User { get; set; }

        private bool _ShowDeleteButton;
        [DefaultValue(true)]
        public bool ShowDeleteButton
        {
            get
            {
                return _ShowDeleteButton;
            }

            set
            {
                _ShowDeleteButton = value;
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
            txtCreateDate.Text = User.CreateDate.ToShortDateString();

            if (!User.IsActive)
            {
                guna2ShadowPanel1.FillColor = Color.Silver;
                guna2ShapesTool1.BorderColor = Color.Silver;
                txtUserName.FillColor = Color.WhiteSmoke;
                txtUserName.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else
            {
                guna2ShadowPanel1.FillColor = Color.White;
                guna2ShapesTool1.BorderColor = Color.White;
                txtUserName.FillColor = Color.WhiteSmoke;
                txtUserName.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        public void FillUser(int UserID)
        {
            if ((User = clsUser.Find(UserID)) != null)
            {
                LoadInfo();
            }

            NoSetNoUserProperties("The entered user id is not valid");
        }

        public void FillUser(string UserName)
        {
            if ((User = clsUser.Find(UserName)) != null)
            {
                LoadInfo();
            }

            NoSetNoUserProperties("The entered username is not valid");
        }

        public void FillUser(clsUser User)
        {
            this.User = User;

            if (User != null)
            {
                LoadInfo();
            }

            NoSetNoUserProperties("User not found");
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

            if (User != null)
            {
                frmUserInfo UserInfo = new frmUserInfo(User);
                UserInfo.ShowDialog();

                LoadInfo();

                UserInfoClosed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void NoSetNoUserProperties(string Message)
        {
            if (User == null)
            {
                lblNoUserMessage.Text = Message;

                lblNoUserMessage.Visible = true;
                pbAccountImage.Visible = false;
                txtUserName.Visible = false;
                btnDelete.Visible = false;
                guna2TextBox6.Visible = false;
                txtCreateDate.Visible = false;
            }
            else
            {
                lblNoUserMessage.Visible = false;
                pbAccountImage.Visible = true;
                txtUserName.Visible = true;
                btnDelete.Visible = ShowDeleteButton;
                guna2TextBox6.Visible = true;
                txtCreateDate.Visible = true;
            }
        }

        private void ucUserCardInfo_Load(object sender, EventArgs e)
        {
            NoSetNoUserProperties("No user has been assigned yet");
        }
    }
}

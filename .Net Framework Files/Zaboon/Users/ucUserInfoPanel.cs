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
    public partial class ucUserInfoPanel : UserControl
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

        public ucUserInfoPanel()
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
                txtUserName.FillColor = Color.WhiteSmoke;
                txtUserName.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else
            {
                guna2ShadowPanel1.FillColor = Color.White;
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

            UpdateUserUIState("The entered user id is not valid");
        }

        public void FillUser(string UserName)
        {
            if ((User = clsUser.Find(UserName)) != null)
            {
                LoadInfo();
            }

            UpdateUserUIState("The entered username is not valid");
        }

        public void FillUser(clsUser User)
        {
            this.User = User;

            if (User != null)
            {
                LoadInfo();
            }

            UpdateUserUIState("User not found");
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

        private void pbAccountImage_Click(object sender, EventArgs e)
        {

            if (User != null)
            {
                frmUserInfo UserInfo = new frmUserInfo(User);
                UserInfo.ShowDialog();

                LoadInfo();

                UserInfoClosed?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Updates the UI controls depending on whether a User exists or not.
        /// If User is null, it shows a "no user" message and hides user details.
        /// Otherwise, it displays the user information.
        /// </summary>
        /// <param name="message">The message to display when no user exists.</param>
        private void UpdateUserUIState(string Message)
        {
            if (User == null)
            {

                // Show "no user" message
                lblNoUserMessage.Text = Message;
                lblNoUserMessage.Visible = true;

                // Hide user-related controls
                pbAccountImage.Visible = false;
                txtUserName.Visible = false;
                btnDelete.Visible = false;
                guna2TextBox6.Visible = false;
                txtCreateDate.Visible = false;
            }
            else 
            {
                // Hide "no user" message
                lblNoUserMessage.Visible = false;

                // Show user-related controls
                pbAccountImage.Visible = true;
                txtUserName.Visible = true;
                btnDelete.Visible = ShowDeleteButton; // depends on condition
                guna2TextBox6.Visible = true;
                txtCreateDate.Visible = true;
            }
        }

        private void ucUserCardInfo_Load(object sender, EventArgs e)
        {
            UpdateUserUIState("No user has been assigned yet");
        }

        public void Clear()
        {
            User = null;
            UpdateUserUIState($"No user has been assigned yet");
        }
    }
}

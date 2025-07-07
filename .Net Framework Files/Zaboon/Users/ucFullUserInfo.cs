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
using static ZaboonBL.clsUserType;

namespace Zaboon
{
    public partial class ucFullUserInfo : UserControl
    {
        public event EventHandler CancelButtonClick;
        public event EventHandler EditButtonClick;
        public event EventHandler SaveButtonClick;

        public clsUser User { get; set; }

        public ucFullUserInfo()
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
            txtUserName.Text = User.UserName;

            if (string.IsNullOrEmpty(User.Email))
                txtEmail.PlaceholderText = "Not appointed";
            else
                txtEmail.Text = User.Email;

            if (string.IsNullOrEmpty(User.Phone))
                txtPhone.PlaceholderText = "Not appointed";
            else
                txtPhone.Text = User.Phone;

            txtCreateDate.Text = User.CreateDate.ToShortDateString();
            txtUserType.Text = $"{User.UserType.Name} account";
            cbIsActive.Checked = User.IsActive;

            LoadImage();
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

            if (this.User != null)
            {
                LoadInfo();
            }
        }

        private void btnShowPermissions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This has not been implemented yet.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelButtonClick?.Invoke(this, EventArgs.Empty);

            SetShowInfoMode();
        }

        private void SetUpdatedInfo()
        {
            User.UserName = txtUserName.Text;
            User.Phone = txtPhone.Text;
            User.Email = txtEmail.Text;
            User.IsActive = cbIsActive.Checked;

            User.ImageByte = clsConverter.ToBytes(pbAccountImage.Image);
        }

        private bool SaveAccountInfo()
        {
            SetUpdatedInfo();

            if (User.Save())
            {
                MessageBox.Show("The account has been saved successfully .",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            else
            {
                MessageBox.Show("Failed to save the account. If the problem persists," +
                    " please seek assistance from the Service and Maintenance Center",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void SetShowInfoMode()
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;

            btnEdit.Visible = true;

            txtUserName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;

            txtUserName.HoverState.BorderColor = Color.Gainsboro;
            txtEmail.HoverState.BorderColor = Color.Gainsboro;
            txtPhone.HoverState.BorderColor = Color.Gainsboro;

            txtUserName.FocusedState.BorderColor = Color.Gainsboro;
            txtEmail.FocusedState.BorderColor = Color.Gainsboro;
            txtPhone.FocusedState.BorderColor = Color.Gainsboro;

            btnSelectImage.Visible = false;
            btnPassword.Visible = false;
            btnPermissions.Visible = false;
        }

        private void SetEditMode()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnEdit.Visible = false;

            txtUserName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;

            txtUserName.HoverState.BorderColor = Color.SeaGreen;
            txtEmail.HoverState.BorderColor = Color.SeaGreen;
            txtPhone.HoverState.BorderColor = Color.SeaGreen;

            txtUserName.FocusedState.BorderColor = Color.SeaGreen;
            txtEmail.FocusedState.BorderColor = Color.SeaGreen;
            txtPhone.FocusedState.BorderColor = Color.SeaGreen;

            btnSelectImage.Visible = true;
            btnPassword.Visible = true;
            btnPermissions.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveAccountInfo())
            {
                SetShowInfoMode();
            }

            pbAccountImage.Image = clsConverter.ToImage(User.ImageByte);

            SaveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This has not been implemented yet.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbAccountImage.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode();

            EditButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

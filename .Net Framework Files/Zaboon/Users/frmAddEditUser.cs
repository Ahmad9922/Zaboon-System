using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaboonBL;
using Dotools;
using System.Security.AccessControl;
using Zaboon.Properties;
using System.IO;

namespace Zaboon
{
    public partial class frmAddEditUser : Form
    {
        private enum enSignUpType { WithEmail = 1, WithPhone }

        private enSignUpType SignUpType { get; set; }

        public clsUser User { get; set; }

        private clsUserType.enUserTypeID UserTypeID { get; set; }

        private bool IsPasswordVisible { get; set; }

        private void InitializeInfo(clsUserType.enUserTypeID UserTypeID)
        {
            this.Text = "Register a new user";

            if (UserTypeID == clsUserType.enUserTypeID.Client)
            {
                lblTitle.Text = "Create a client account";
            }
            else
            {
                lblTitle.Text = "Create an employee account";
            }

            this.SignUpType = enSignUpType.WithPhone;
            this.UserTypeID = UserTypeID;
            AcceptButton = btnNext;
        }

        public frmAddEditUser(clsUserType.enUserTypeID UserTypeID)
        {
            InitializeComponent();

            InitializeInfo(UserTypeID);
        }

        private void linkByEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (SignUpType)
            {
                case enSignUpType.WithEmail:
                    txtPhone.Visible = true;
                    txtEmail.Visible = false;
                    SignUpType = enSignUpType.WithPhone;
                    linkChangeLoginType.Text = "Sign up by email";
                    txtPhone.Focus();
                    break;

                case enSignUpType.WithPhone:
                    txtEmail.Visible = true;
                    txtPhone.Visible = false;
                    SignUpType = enSignUpType.WithEmail;
                    linkChangeLoginType.Text = "Sign up by phone";
                    txtEmail.Focus();
                    break;
            }
        }

        private bool ValidateSignUpType()
        {
            switch (SignUpType)
            {
                case enSignUpType.WithEmail:
                    return clsValidate.ValidateEmail(txtEmail.Text);

                case enSignUpType.WithPhone:
                    return clsValidate.ValidatePhone(txtPhone.Text);
            }

            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateSignUpType())
            {
                guna2TabControl1.SelectTab(1);
                AcceptButton = btnSignUp;
            }
            else
            {
                string InputItem = string.Empty;

                switch (SignUpType)
                {
                    case enSignUpType.WithEmail:
                        InputItem = "email address";
                        break;

                    case enSignUpType.WithPhone:
                        InputItem = "phone number";
                        break;
                }

                MessageBox.Show($"Your {InputItem} is invalid. Please check it and try again .",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePassword()
        {
            bool IsNullOrEmpty = false;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPasswordErrorMessage.Text = "This field is required.";
                lblPasswordErrorMessage.Visible = true;

                IsNullOrEmpty = true;
            }
            else
            {
                lblPasswordErrorMessage.Text = string.Empty;
                lblPasswordErrorMessage.Visible = false;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblConfirmPasswordErrorMessage.Text = "This field is required.";
                lblConfirmPasswordErrorMessage.Visible = true;

                IsNullOrEmpty = true;
            }
            else
            {
                lblConfirmPasswordErrorMessage.Text = string.Empty;
                lblConfirmPasswordErrorMessage.Visible = false;
            }

            if (IsNullOrEmpty)
            {
                return false;
            }

            if (txtPassword.Text.Length >= 8)
            {
                bool IsValidate = txtPassword.Text == txtConfirmPassword.Text;

                if (IsValidate)
                {
                    lblConfirmPasswordErrorMessage.Text = string.Empty;
                    lblConfirmPasswordErrorMessage.Visible = false;

                    lblPasswordErrorMessage.Text = string.Empty;
                    lblPasswordErrorMessage.Visible = false;
                }
                else
                {
                    lblConfirmPasswordErrorMessage.Text = "Password is not Match";
                    lblConfirmPasswordErrorMessage.Visible = true;
                }

                return IsValidate;
            }
            else
            {
                lblPasswordErrorMessage.Text = "Password is too short. It must be at least 8 characters long.";
                lblPasswordErrorMessage.Visible = true;
            }
            
            return false;
        }

        private bool ValidateUserName()
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                bool IsValidate = !clsUser.IsExist(txtUserName.Text);

                if (IsValidate)
                {
                    lblUserNameErrorMessage.Text = string.Empty;
                    lblUserNameErrorMessage.Visible = false;
                }
                else
                {
                    lblUserNameErrorMessage.Text = "Invalid username.";
                    lblUserNameErrorMessage.Visible = true;
                }

                return IsValidate;
            }

            lblUserNameErrorMessage.Text = "This field is required.";
            lblUserNameErrorMessage.Visible = true;
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(0);
            AcceptButton = btnNext;
        }

        private bool ValidateSignUpInfo()
        {
            bool IsValidate = false;

            bool UserNameResult = ValidateUserName();
            bool PasswordResult = ValidatePassword();

            IsValidate = PasswordResult && UserNameResult;

            return IsValidate;
        }

        private void SetSignUpInfo()
        {
            switch (SignUpType)
            {
                case enSignUpType.WithPhone:
                    User = clsUser.AddWithPhone(txtPhone.Text, txtUserName.Text, txtPassword.Text, clsUserType.Find(UserTypeID));
                    break;

                case enSignUpType.WithEmail:
                    User = clsUser.AddWithEmail(txtEmail.Text, txtUserName.Text, txtPassword.Text, clsUserType.Find(UserTypeID));
                    break;
            }

            User.ImageByte = clsConverter.ToBytes(pbAccountImage.Image);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateSignUpInfo())
            {
                guna2TabControl1.SelectTab(2);
                AcceptButton = btnOk;
            }
        }

        private void Password_IconRightClick(object sender, EventArgs e)
        {
            if (IsPasswordVisible)
            {
                txtPassword.IconRight = Resources.visibility_off;
                txtPassword.UseSystemPasswordChar = true;
                IsPasswordVisible = false;
            }
            else
            {
                txtPassword.IconRight = Resources.visibility;
                txtPassword.UseSystemPasswordChar = false;
                IsPasswordVisible = true;
            }
        }

        private bool SaveAccount()
        {
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetSignUpInfo();

            if (SaveAccount())
            {
                this.Close();
            }
        }

        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            txtPhone.Focus();
        }

        private void btnSkipImage_Click(object sender, EventArgs e)
        {
            pbAccountImage.Image = null;
        }
    }
}

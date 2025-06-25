using ZaboonDAL;
 using Dotools;
 using System;
 using System.Collections.Generic;
 using System.Data;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace ZaboonBL
{
    public class clsUser
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2,
        }

        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public int? Permissions { get; set; }
        public byte[] ImageByte { get; set; }
        public DateTime CreateDate { get; set; }
        public clsUserType UserType { get; set; }
        public enMode Mode { get; private set; }

        private clsUser(string UserName, string Password, clsUserType UserType)
        {
            UserID = null;
            this.UserName = UserName;
            this.Password = Password;
            Email = null;
            Phone = null;
            IsActive = true;
            Permissions = null;
            ImageByte = null;
            CreateDate = DateTime.Now;
            this.UserType = UserType;

            this.Mode = enMode.AddNew;
        }

        private clsUser(clsUserDataAccess.clsUserData UserData)
        {
            UserID = UserData.UserID;
            UserName = UserData.UserName;
            Password = UserData.Password;
            Email = UserData.Email;
            Phone = UserData.Phone;
            IsActive = UserData.IsActive;
            Permissions = UserData.Permissions;
            ImageByte = UserData.ImageByte;
            CreateDate = UserData.CreateDate;
            UserType = clsUserType.Find((clsUserType.enUserTypeID)UserData.UserTypeID);

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserID = UserID;
            UserData.UserName = UserName;
            UserData.Password = Password;
            UserData.Email = Email;
            UserData.Phone = Phone;
            UserData.IsActive = IsActive;
            UserData.Permissions = Permissions;
            UserData.ImageByte = ImageByte;
            UserData.CreateDate = CreateDate;
            UserData.UserTypeID = Convert.ToInt32(UserType.UserTypeID);

            this.UserID = clsUserDataAccess.Add(UserData);

            return this.UserID != null;
        }

        private bool _Update()
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserID = UserID;
            UserData.UserName = UserName;
            UserData.Password = Password;
            UserData.Email = Email;
            UserData.Phone = Phone;
            UserData.IsActive = IsActive;
            UserData.Permissions = Permissions;
            UserData.ImageByte = ImageByte;
            UserData.CreateDate = CreateDate;
            UserData.UserTypeID = Convert.ToInt32(UserType.UserTypeID);

            return clsUserDataAccess.Update(UserData);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Update();
            }

            return false;
        }

        public bool Delete()
        {
            return clsUserDataAccess.Delete(UserID.Value);
        }

        public static clsUser AddWithEmail(string Email, string UserName, string Password, clsUserType UserType)
        {
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(UserName)
                && !string.IsNullOrEmpty(Password) && UserType != null)
            {
                clsUser User = new clsUser(UserName, clsConverter.ComputeHash(Password), UserType);

                User.Email = Email;

                return User;
            }
            else
            {
                return null;
            }
        }

        public static clsUser AddWithPhone(string Phone, string UserName, string Password, clsUserType UserType)
        {
            if (!string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(UserName)
                && !string.IsNullOrEmpty(Password) && UserType != null)
            {
                clsUser User = new clsUser(UserName, clsConverter.ComputeHash(Password), UserType);

                User.Phone = Phone;

                return User;
            }
            else
            {
                return null;
            }
        }

        public static clsUser Find(int UserID)
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserID = UserID;

            if (clsUserDataAccess.GetByID(UserData))
            {
                return new clsUser(UserData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int UserID)
        {
            return clsUserDataAccess.IsExist(UserID);
        }

        public static bool IsExist(string UserName)
        {
            return clsUserDataAccess.IsExist(UserName);
        }

        public static DataTable GetList()
        {
            return clsUserDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsUserDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        private static List<clsUser> _GetUsers(List<clsUserDataAccess.clsUserData> UsersData)
        {
            List<clsUser> UsersTypes = new List<clsUser>();

            foreach (clsUserDataAccess.clsUserData UserTypeData in UsersData)
            {
                UsersTypes.Add(new clsUser(UserTypeData));
            }

            return UsersTypes;
        }

        public static List<clsUser> GetUsers()
        {
            return _GetUsers(clsUserDataAccess.GetUsers());
        }

        public static List<clsUser> GetUsers(clsUserType.enUserTypeID UserTypeID)
        {
            return _GetUsers(clsUserDataAccess.GetUsers(Convert.ToInt32(UserTypeID)));
        }

        public static bool Delete(int UserID)
        {
            return clsUserDataAccess.Delete(UserID);
        }

    }
}
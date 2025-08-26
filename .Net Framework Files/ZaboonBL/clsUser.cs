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
    /// <summary>
    /// Business layer class that represents a user and encapsulates domain logic
    /// for creating, updating, finding, and querying users. Persists via clsUserDataAccess.
    /// </summary>
    public class clsUser
    {
        #region Enums / Mode

        /// <summary>
        /// Form/object mode for persistence control.
        /// </summary>
        public enum enMode
        {
            /// <summary>
            /// New user (not yet saved to DB).
            /// </summary>
            AddNew = 1,

            /// <summary>
            /// Existing user (already persisted; updates will be saved).
            /// </summary>
            Update = 2,
        }

        #endregion

        #region Properties

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

        /// <summary>
        /// Current object mode (AddNew/Update).
        /// </summary>
        public enMode Mode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor to prepare a new user in AddNew mode.
        /// </summary>
        /// <param name="UserName">Login user name.</param>
        /// <param name="Password">Password (expected hashed by caller if needed).</param>
        /// <param name="UserType">Target user type.</param>
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

        /// <summary>
        /// Private constructor to materialize an existing user from DAL data (Update mode).
        /// </summary>
        /// <param name="UserData">DAL DTO loaded from database.</param>
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

        #endregion

        #region Persistence (Private)

        /// <summary>
        /// Adds the current user to the database and sets <see cref="UserID"/> on success.
        /// </summary>
        /// <returns>True if added successfully; otherwise, false.</returns>
        private bool _Add()
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData
            {
                UserID = UserID,
                UserName = UserName,
                Password = Password,
                Email = Email,
                Phone = Phone,
                IsActive = IsActive,
                Permissions = Permissions,
                ImageByte = ImageByte,
                CreateDate = CreateDate,
                UserTypeID = Convert.ToInt32(UserType.UserTypeID)
            };

            this.UserID = clsUserDataAccess.Add(UserData);

            return this.UserID != null;
        }

        /// <summary>
        /// Updates the current user in the database.
        /// </summary>
        /// <returns>True if updated successfully; otherwise, false.</returns>
        private bool _Update()
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData
            {
                UserID = UserID,
                UserName = UserName,
                Password = Password,
                Email = Email,
                Phone = Phone,
                IsActive = IsActive,
                Permissions = Permissions,
                ImageByte = ImageByte,
                CreateDate = CreateDate,
                UserTypeID = Convert.ToInt32(UserType.UserTypeID)
            };

            return clsUserDataAccess.Update(UserData);
        }

        #endregion

        #region Persistence (Public)

        /// <summary>
        /// Saves the user:
        /// - If <see cref="Mode"/> is AddNew: inserts then switches to Update mode.
        /// - If <see cref="Mode"/> is Update: updates the record.
        /// </summary>
        /// <returns>True if the operation succeeded; otherwise, false.</returns>
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

        /// <summary>
        /// Deletes the current user by <see cref="UserID"/>.
        /// </summary>
        /// <returns>True if deletion succeeded; otherwise, false.</returns>
        /// <remarks>Assumes <see cref="UserID"/> has a value.</remarks>
        public bool Delete()
        {
            return clsUserDataAccess.Delete(UserID.Value);
        }

        #endregion

        #region Domain helpers (instance)

        /// <summary>
        /// Gets how many reservations this user has for a specific service.
        /// </summary>
        /// <param name="ServiceID">Target service identifier.</param>
        /// <returns>Number of reservations for this user with the given service.</returns>
        public int GetReservationCount(int ServiceID)
        {
            return clsReservation.GetResrvationCount(ServiceID, UserID.Value);
        }

        /// <summary>
        /// Indicates whether the user has at least one reservation for a specific service.
        /// </summary>
        /// <param name="ServiceID">Target service identifier.</param>
        /// <returns>True if one or more reservations exist; otherwise, false.</returns>
        public bool HasReservationInService(int ServiceID)
        {
            return GetReservationCount(ServiceID) > 0;
        }

        #endregion

        #region Factories (static)

        /// <summary>
        /// Creates a new user (AddNew mode) with email and hashed password.
        /// Note: call <see cref="Save"/> to persist.
        /// </summary>
        /// <param name="Email">Email to assign.</param>
        /// <param name="UserName">User name (login).</param>
        /// <param name="Password">Plain password (will be hashed).</param>
        /// <param name="UserType">User type object.</param>
        /// <returns>A new <see cref="clsUser"/> in AddNew mode, or null if inputs are invalid.</returns>
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

        /// <summary>
        /// Creates a new user (AddNew mode) with phone and hashed password.
        /// Note: call <see cref="Save"/> to persist.
        /// </summary>
        /// <param name="Phone">Phone to assign.</param>
        /// <param name="UserName">User name (login).</param>
        /// <param name="Password">Plain password (will be hashed).</param>
        /// <param name="UserType">User type object.</param>
        /// <returns>A new <see cref="clsUser"/> in AddNew mode, or null if inputs are invalid.</returns>
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

        #endregion

        #region Finders (static)

        /// <summary>
        /// Finds a user by ID.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <returns>User instance if found; otherwise, null.</returns>
        public static clsUser Find(int UserID)
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserID = UserID;

            if (clsUserDataAccess.GetById(UserData))
            {
                return new clsUser(UserData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds a user by user name.
        /// </summary>
        /// <param name="UserName">Login user name.</param>
        /// <returns>User instance if found; otherwise, null.</returns>
        public static clsUser Find(string UserName)
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserName = UserName;

            if (clsUserDataAccess.GetByUserName(UserData))
            {
                return new clsUser(UserData);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds a user by credentials.
        /// </summary>
        /// <param name="UserName">Login user name.</param>
        /// <param name="Password">Plain password (will be hashed for lookup).</param>
        /// <returns>User instance if found; otherwise, null.</returns>
        public static clsUser Find(string UserName, string Password)
        {
            clsUserDataAccess.clsUserData UserData = new clsUserDataAccess.clsUserData();

            UserData.UserName = UserName;
            UserData.Password = clsConverter.ComputeHash(Password);

            if (clsUserDataAccess.GetByCredentials(UserData))
            {
                return new clsUser(UserData);
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Existence (static)

        /// <summary>
        /// Checks whether a user exists by ID.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        public static bool Exists(int UserID)
        {
            return clsUserDataAccess.Exists(UserID);
        }

        /// <summary>
        /// Checks whether a user exists by user name.
        /// </summary>
        /// <param name="UserName">Login user name.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        public static bool Exists(string UserName)
        {
            return clsUserDataAccess.Exists(UserName);
        }

        #endregion

        #region Listing / Filtering (static)

        /// <summary>
        /// Retrieves all users as a DataTable.
        /// </summary>
        /// <returns>DataTable containing user records.</returns>
        public static DataTable GetAll()
        {
            return clsUserDataAccess.GetAll();
        }

        /// <summary>
        /// Retrieves filtered users as a DataTable.
        /// </summary>
        /// <param name="Value">Filter value (string).</param>
        /// <param name="FieldName">Target field name to filter by.</param>
        /// <returns>DataTable with filtered rows.</returns>
        public static DataTable GetFiltered(string Value, string FieldName)
        {
            return clsUserDataAccess.GetFiltered(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        /// <summary>
        /// Maps DAL DTOs to domain clsUser objects.
        /// </summary>
        /// <param name="UsersData">List of DAL user DTOs.</param>
        /// <returns>List of materialized <see cref="clsUser"/>.</returns>
        private static List<clsUser> _GetUsers(List<clsUserDataAccess.clsUserData> UsersData)
        {
            List<clsUser> UsersTypes = new List<clsUser>();

            foreach (clsUserDataAccess.clsUserData UserTypeData in UsersData)
            {
                UsersTypes.Add(new clsUser(UserTypeData));
            }

            return UsersTypes;
        }

        /// <summary>
        /// Gets all users as domain objects.
        /// </summary>
        /// <returns>List of <see cref="clsUser"/>.</returns>
        public static List<clsUser> GetUsers()
        {
            return _GetUsers(clsUserDataAccess.GetUsers());
        }

        /// <summary>
        /// Gets users by user type (domain enum).
        /// </summary>
        /// <param name="UserTypeID">User type ID (enum).</param>
        /// <returns>List of <see cref="clsUser"/>.</returns>
        public static List<clsUser> GetUsers(clsUserType.enUserTypeID UserTypeID)
        {
            return _GetUsers(clsUserDataAccess.GetUsers(Convert.ToInt32(UserTypeID)));
        }

        #endregion

        #region Delete / Counters (static)

        /// <summary>
        /// Deletes a user by ID.
        /// </summary>
        /// <param name="UserID">User identifier.</param>
        /// <returns>True if deletion succeeded; otherwise, false.</returns>
        public static bool Delete(int UserID)
        {
            return clsUserDataAccess.Delete(UserID);
        }

        /// <summary>
        /// Total users count.
        /// </summary>
        /// <returns>Number of users.</returns>
        public static int GetUsersCount()
        {
            return clsUserDataAccess.GetUsersCount();
        }

        /// <summary>
        /// Active users count.
        /// </summary>
        /// <returns>Number of active users.</returns>
        public static int GetActiveUsersCount()
        {
            return clsUserDataAccess.GetActiveUsersCount();
        }

        /// <summary>
        /// Inactive users count.
        /// </summary>
        /// <returns>Number of inactive users.</returns>
        public static int GetInactiveUsersCount()
        {
            return clsUserDataAccess.GetInactiveUsersCount();
        }

        /// <summary>
        /// Clients count.
        /// </summary>
        /// <returns>Number of clients.</returns>
        public static int GetClientsCount()
        {
            return clsUserDataAccess.GetClientsCount();
        }

        /// <summary>
        /// Employees count.
        /// </summary>
        /// <returns>Number of employees.</returns>
        public static int GetEmployeesCount()
        {
            return clsUserDataAccess.GetEmployeesCount();
        }

        #endregion
    }
}
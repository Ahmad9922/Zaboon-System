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
    /// Business layer class that represents a user type (e.g., Client, Employee).
    /// Encapsulates read/update operations and mapping from DAL (clsUserTypeDataAccess).
    /// </summary>
    public class clsUserType
    {
        #region Enums

        /// <summary>
        /// Well-known user type identifiers (seeded in the database).
        /// </summary>
        public enum enUserTypeID
        {
            /// <summary>
            /// Client user type (ID = 1).
            /// </summary>
            Client = 1,

            /// <summary>
            /// Employee user type (ID = 2).
            /// </summary>
            Employee = 2
        }

        #endregion

        #region Properties

        public enUserTypeID UserTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor that materializes a domain object from DAL DTO.
        /// </summary>
        /// <param name="UserTypeData">DAL DTO loaded from the database.</param>
        private clsUserType(clsUserTypeDataAccess.clsUserTypeData UserTypeData)
        {
            UserTypeID = (enUserTypeID)UserTypeData.UserTypeID;
            Name = UserTypeData.Name;
            Description = UserTypeData.Description;
        }

        #endregion

        #region Persistence

        /// <summary>
        /// Updates the current user type (Name/Description) in the database.
        /// </summary>
        /// <returns>True if one or more rows were affected; otherwise, false.</returns>
        private bool _Update()
        {
            clsUserTypeDataAccess.clsUserTypeData UserTypeData = new clsUserTypeDataAccess.clsUserTypeData
            {
                UserTypeID = Convert.ToInt32(UserTypeID),
                Name = Name,
                Description = Description
            };

            return clsUserTypeDataAccess.Update(UserTypeData);
        }

        /// <summary>
        /// Saves the user type.
        /// Note: this class supports update only (no add), assuming user types are seeded.
        /// </summary>
        /// <returns>True if the update succeeded; otherwise, false.</returns>
        public bool Save()
        {
            return _Update();
        }

        #endregion

        #region Finders (static)

        /// <summary>
        /// Finds a user type by its identifier.
        /// </summary>
        /// <param name="UserTypeID">User type enum identifier.</param>
        /// <returns>clsUserType instance if found; otherwise, null.</returns>
        public static clsUserType Find(enUserTypeID UserTypeID)
        {
            clsUserTypeDataAccess.clsUserTypeData UserTypeData = new clsUserTypeDataAccess.clsUserTypeData
            {
                UserTypeID = Convert.ToInt32(UserTypeID)
            };

            if (clsUserTypeDataAccess.GetByID(UserTypeData))
            {
                return new clsUserType(UserTypeData);
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Existence (static)

        /// <summary>
        /// Checks if a user type exists by its identifier.
        /// </summary>
        /// <param name="UserTypeID">User type enum identifier.</param>
        /// <returns>True if exists; otherwise, false.</returns>
        public static bool IsExist(enUserTypeID UserTypeID)
        {
            return clsUserTypeDataAccess.IsExist(Convert.ToInt32(UserTypeID));
        }

        #endregion

        #region Listing / Filters (static)

        /// <summary>
        /// Retrieves all user types as a DataTable.
        /// </summary>
        /// <returns>DataTable with all user types.</returns>
        public static DataTable GetList()
        {
            return clsUserTypeDataAccess.GetList();
        }

        /// <summary>
        /// Retrieves a filtered list of user types as a DataTable.
        /// </summary>
        /// <param name="Value">Filter value.</param>
        /// <param name="FieldName">Target field name to filter by.</param>
        /// <returns>DataTable with filtered user types.</returns>
        public static DataTable GetList(string Value, string FieldName)
        {
            return clsUserTypeDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        /// <summary>
        /// Retrieves all user types as domain objects.
        /// </summary>
        /// <returns>List of clsUserType.</returns>
        public static List<clsUserType> GetUserTypes()
        {
            List<clsUserTypeDataAccess.clsUserTypeData> UsersTypesData = clsUserTypeDataAccess.GetUsersTypes();

            List<clsUserType> UsersTypes = new List<clsUserType>();

            foreach (clsUserTypeDataAccess.clsUserTypeData UserTypeData in UsersTypesData)
            {
                UsersTypes.Add(new clsUserType(UserTypeData));
            }

            return UsersTypes;
        }

        #endregion
    }
}
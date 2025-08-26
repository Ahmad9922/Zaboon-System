using Dotools;
 using System;
 using System.Collections.Generic;
 using System.Data;
 using System.Data.SqlClient;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace ZaboonDAL
{
    /// <summary>
    /// Data Access Layer for the UsersTypes table.
    /// Provides CRUD operations, listing, and existence checks for user types.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsUserTypeDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a UserType entity matching the UsersTypes table.
        /// </summary>
        public class clsUserTypeData
        {
            public int? UserTypeID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        #endregion

        #region CRUD

        /// <summary>
        /// Retrieves a UserType by its ID and fills the provided DTO if found.
        /// </summary>
        /// <param name="UserTypeData">
        /// Input: DTO with <c>UserTypeID</c> set. 
        /// Output: remaining fields are populated if a record is found.
        /// </param>
        /// <returns>True if the UserType exists; otherwise, false.</returns>
        public static bool GetByID(clsUserTypeData UserTypeData)
        {
            string Query = "SELECT * FROM UsersTypes WHERE UserTypeID = @UserTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserTypeData);
            }, Query, new SqlParameter("@UserTypeID", UserTypeData.UserTypeID));
        }

        /// <summary>
        /// Adds a new UserType to the database.
        /// </summary>
        /// <param name="UserTypeData">The UserType DTO to add (Name, Description).</param>
        /// <returns>The ID of the newly created UserType.</returns>
        public static int Add(clsUserTypeData UserTypeData)
        {
            string Query = @"
        INSERT INTO [dbo].[UsersTypes] ([Name], [Description]) 
        VALUES (@Name, @Description)
        SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));
            }, Query, UserTypeData);
        }

        /// <summary>
        /// Updates an existing UserType in the database.
        /// </summary>
        /// <param name="UserTypeData">The UserType DTO containing updated data (must include <c>UserTypeID</c>).</param>
        /// <returns>True if update succeeded (affected rows &gt; 0); otherwise, false.</returns>
        public static bool Update(clsUserTypeData UserTypeData)
        {
            string Query = @"
        UPDATE [dbo].[UsersTypes] 
        SET [Name] = @Name, [Description] = @Description 
        WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);
            }, Query, UserTypeData) > 0;
        }

        /// <summary>
        /// Deletes a UserType from the database.
        /// </summary>
        /// <param name="UserTypeID">The ID of the UserType to delete.</param>
        /// <returns>True if deletion succeeded (affected rows &gt; 0); otherwise, false.</returns>
        public static bool Delete(int UserTypeID)
        {
            string Query = @"DELETE FROM [UsersTypes] WHERE UserTypeID = @UserTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);
            }, Query, new SqlParameter("@UserTypeID", UserTypeID)) > 0;
        }

        #endregion

        #region Lists / Filters

        /// <summary>
        /// Retrieves all UserTypes as a DataTable.
        /// </summary>
        /// <returns>A <see cref="DataTable"/> containing all UserTypes.</returns>
        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);
            }, Query);
        }

        /// <summary>
        /// Retrieves a filtered list of UserTypes as a DataTable.
        /// </summary>
        /// <param name="FilterData">The filter conditions applied by the underlying executor.</param>
        /// <returns>A <see cref="DataTable"/> containing filtered UserTypes.</returns>
        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);
            }, Query);
        }

        /// <summary>
        /// Retrieves all UserTypes as a strongly-typed list.
        /// </summary>
        /// <returns>A list of <see cref="clsUserTypeData"/> entities.</returns>
        public static List<clsUserTypeData> GetUsersTypes()
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsUserTypeData>(Command);
            }, Query);
        }

        #endregion

        #region Existence

        /// <summary>
        /// Checks if a UserType exists by its ID.
        /// </summary>
        /// <param name="UserTypeID">The ID of the UserType to check.</param>
        /// <returns>True if the UserType exists; otherwise, false.</returns>
        public static bool IsExist(int UserTypeID)
        {
            string Query = @"SELECT R = 1 FROM UsersTypes WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);
            }, Query, new SqlParameter("@UserTypeID", UserTypeID)) != null;
        }

        #endregion
    }
}
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
    /// Data Access Layer for the Users table.
    /// Provides CRUD operations, queries, and counters for users.
    /// Relies on clsAdoQueryExecutor for executing parameterized SQL and mapping results.
    /// </summary>
    public static class clsUserDataAccess
    {
        #region DTO

        /// <summary>
        /// Represents a User entity matching the database Users table.
        /// </summary>
        public class clsUserData
        {
            public int? UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool IsActive { get; set; }
            public int? Permissions { get; set; }
            public byte[] ImageByte { get; set; }
            public DateTime CreateDate { get; set; }
            public int UserTypeID { get; set; }
        }

        #endregion

        #region Get Methods

        /// <summary>
        /// Gets a user by its ID and fills the provided DTO if found.
        /// </summary>
        /// <param name="user">Input: DTO with <c>UserID</c> set. Output: remaining fields are populated if found.</param>
        /// <returns>True if a record is found; otherwise, false.</returns>
        public static bool GetById(clsUserData user)
        {
            const string query = "SELECT * FROM Users WHERE UserID = @UserID;";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader(cmd, user),
                query, new SqlParameter("@UserID", user.UserID));
        }

        /// <summary>
        /// Gets a user by its username and fills the provided DTO if found.
        /// </summary>
        /// <param name="user">Input: DTO with <c>UserName</c> set. Output: remaining fields are populated if found.</param>
        /// <returns>True if a record is found; otherwise, false.</returns>
        public static bool GetByUserName(clsUserData user)
        {
            const string query = "SELECT * FROM Users WHERE UserName = @UserName;";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader(cmd, user),
                query, new SqlParameter("@UserName", user.UserName));
        }

        /// <summary>
        /// Gets a user by its username and password and fills the provided DTO if found.
        /// </summary>
        /// <param name="user">Input: DTO with <c>UserName</c> and <c>Password</c> set. Output: remaining fields are populated if found.</param>
        /// <returns>True if a record is found; otherwise, false.</returns>
        public static bool GetByCredentials(clsUserData user)
        {
            const string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password;";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader(cmd, user),
                query, new SqlParameter[]
                {
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password)
                });
        }

        #endregion

        #region Insert / Update / Delete

        /// <summary>
        /// Adds a new user and returns the generated UserID.
        /// </summary>
        /// <param name="user">DTO containing the user data to insert.</param>
        /// <returns>The newly generated <c>UserID</c>.</returns>
        public static int Add(clsUserData user)
        {
            const string query = @"
         INSERT INTO [dbo].[Users] 
         ([UserName], [Password], [Email], [Phone], [IsActive], [Permissions], [ImageByte], [CreateDate], [UserTypeID])
         VALUES (@UserName, @Password, @Email, @Phone, @IsActive, @Permissions, @ImageByte, @CreateDate, @UserTypeID)
         SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(cmd)), query, user);
        }

        /// <summary>
        /// Updates an existing user.
        /// </summary>
        /// <param name="user">DTO with the fields to update (must include <c>UserID</c>).</param>
        /// <returns>True if one or more rows were affected; otherwise, false.</returns>
        public static bool Update(clsUserData user)
        {
            const string query = @"
         UPDATE [dbo].[Users] SET 
             [UserName] = @UserName,
             [Password] = @Password,
             [Email] = @Email,
             [Phone] = @Phone,
             [IsActive] = @IsActive,
             [Permissions] = @Permissions,
             [ImageByte] = @ImageByte,
             [CreateDate] = @CreateDate,
             [UserTypeID] = @UserTypeID
         WHERE UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteNonQuery(cmd), query, user) > 0;
        }

        /// <summary>
        /// Deletes a user by ID.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>True if a row was deleted; otherwise, false.</returns>
        public static bool Delete(int userId)
        {
            const string query = "DELETE FROM [Users] WHERE UserID = @UserID;";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteNonQuery(cmd),
                query, new SqlParameter("@UserID", userId)) > 0;
        }

        #endregion

        #region List Methods

        /// <summary>
        /// Gets all users as DataTable.
        /// </summary>
        /// <returns><see cref="DataTable"/> containing all users.</returns>
        public static DataTable GetAll()
        {
            const string query = "SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader(cmd), query);
        }

        /// <summary>
        /// Gets filtered users as DataTable.
        /// </summary>
        /// <param name="filter">Filter object used by the underlying executor to apply conditions.</param>
        /// <returns><see cref="DataTable"/> containing filtered users.</returns>
        public static DataTable GetFiltered(clsDataTypes.clsFilterData filter)
        {
            const string query = "SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader(cmd, filter), query);
        }

        /// <summary>
        /// Gets all users as a strongly-typed list.
        /// </summary>
        /// <returns>List of <see cref="clsUserData"/>.</returns>
        public static List<clsUserData> GetUsers()
        {
            const string query = "SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader<clsUserData>(cmd), query);
        }

        /// <summary>
        /// Gets users filtered by user type.
        /// </summary>
        /// <param name="userTypeId">User type identifier (e.g., 1 = Client, 2 = Employee).</param>
        /// <returns>List of <see cref="clsUserData"/> for the given type.</returns>
        public static List<clsUserData> GetUsers(int userTypeId)
        {
            const string query = "SELECT * FROM Users WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteReader<clsUserData>(cmd),
                query, new SqlParameter("@UserTypeID", userTypeId));
        }

        #endregion

        #region Existence Check

        /// <summary>
        /// Checks if a user exists by ID.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>True if the user exists; otherwise, false.</returns>
        public static bool Exists(int userId)
        {
            const string query = "SELECT 1 FROM Users WHERE UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd),
                query, new SqlParameter("@UserID", userId)) != null;
        }

        /// <summary>
        /// Checks if a user exists by username.
        /// </summary>
        /// <param name="userName">The username to check.</param>
        /// <returns>True if a user with the given username exists; otherwise, false.</returns>
        public static bool Exists(string userName)
        {
            const string query = "SELECT 1 FROM Users WHERE UserName = @UserName";

            return clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd),
                query, new SqlParameter("@UserName", userName)) != null;
        }

        #endregion

        #region Counters

        /// <summary>
        /// Gets the total number of users.
        /// </summary>
        /// <returns>Total users count.</returns>
        public static int GetUsersCount()
        {
            const string query = "SELECT COUNT(UserID) FROM Users";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd), query));
        }

        /// <summary>
        /// Gets the number of active users.
        /// </summary>
        /// <returns>Active users count.</returns>
        public static int GetActiveUsersCount()
        {
            const string query = "SELECT COUNT(UserID) FROM Users WHERE IsActive = 1";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd), query));
        }

        /// <summary>
        /// Gets the number of inactive users.
        /// </summary>
        /// <returns>Inactive users count.</returns>
        public static int GetInactiveUsersCount()
        {
            const string query = "SELECT COUNT(UserID) FROM Users WHERE IsActive = 0";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd), query));
        }

        /// <summary>
        /// Gets the number of clients (by UserTypeID).
        /// </summary>
        /// <returns>Clients count.</returns>
        /// <remarks>Assumes 1 = Client. Adjust according to your seed data.</remarks>
        public static int GetClientsCount()
        {
            const string query = "SELECT COUNT(UserID) FROM Users WHERE UserTypeID = 1";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd), query));
        }

        /// <summary>
        /// Gets the number of employees (by UserTypeID).
        /// </summary>
        /// <returns>Employees count.</returns>
        /// <remarks>Assumes 2 = Employee. Adjust according to your seed data.</remarks>
        public static int GetEmployeesCount()
        {
            const string query = "SELECT COUNT(UserID) FROM Users WHERE UserTypeID = 2";

            return Convert.ToInt32(clsAdoQueryExecutor.ExecuteQuery(cmd =>
                clsAdoQueryExecutor.ExecuteScalar(cmd), query));
        }

        #endregion
    }
}
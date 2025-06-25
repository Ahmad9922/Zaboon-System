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
    public static class clsUserDataAccess
    {
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

        public static bool GetByID(clsUserData UserData)
        {
            string Query = "SELECT * FROM Users WHERE UserID = @UserID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserData);

            }, Query, new SqlParameter("@UserID", UserData.UserID));
        }

        public static int Add(clsUserData UserData)
        {
            string Query = @"INSERT INTO [dbo].[Users] ( 
                             [UserName], [Password], [Email], [Phone], [IsActive], [Permissions], [ImageByte], [CreateDate], [UserTypeID])
                              VALUES ( @UserName, @Password, @Email, @Phone, @IsActive, @Permissions, @ImageByte, @CreateDate, @UserTypeID)
                              SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, UserData);
        }

        public static bool Update(clsUserData UserData)
        {
            string Query = @"UPDATE [dbo].[Users] SET 
                            [UserName] = @UserName,
                            [Password] = @Password,
                            [Email] = @Email,
                            [Phone] = @Phone,
                            [IsActive] = @IsActive,
                            [Permissions] = @Permissions,
                            [ImageByte] = @ImageByte,
                            [CreateDate] = @CreateDate,
                            [UserTypeID] = @UserTypeID WHERE UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, UserData) > 0;
        }

        public static bool Delete(int UserID)
        {
            string Query = @"DELETE FROM [Users] WHERE UserID = @UserID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@UserID", UserID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static List<clsUserData> GetUsers()
        {
            string Query = @"SELECT * FROM Users";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsUserData>(Command);

            }, Query);
        }

        public static List<clsUserData> GetUsers(int UserTypeID)
        {
            string Query = @"SELECT * FROM Users WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsUserData>(Command);

            }, Query, new SqlParameter("@UserTypeID", UserTypeID));
        }

        public static bool IsExist(int UserID)
        {
            string Query = @"SELECT R = 1 FROM Users WHERE UserID = @UserID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@UserID", UserID)) != null;
        }

        public static bool IsExist(string UserName)
        {
            string Query = @"SELECT R = 1 FROM Users WHERE UserName = @UserName";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@UserName", UserName)) != null;
        }
    }
}
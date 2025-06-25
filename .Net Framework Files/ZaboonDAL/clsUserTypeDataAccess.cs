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
    public static class clsUserTypeDataAccess
    {
        public class clsUserTypeData
        {
            public int? UserTypeID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

        }

        public static bool GetByID(clsUserTypeData UserTypeData)
        {
            string Query = "SELECT * FROM UsersTypes WHERE UserTypeID = @UserTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, UserTypeData);

            }, Query, new SqlParameter("@UserTypeID", UserTypeData.UserTypeID));
        }

        public static int Add(clsUserTypeData UserTypeData)
        {
            string Query = @"INSERT INTO [dbo].[UsersTypes] ( 
[Name], [Description])
 VALUES ( @Name, @Description)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, UserTypeData);
        }

        public static bool Update(clsUserTypeData UserTypeData)
        {
            string Query = @"UPDATE [dbo].[UsersTypes] SET 
[Name] = @Name,
[Description] = @Description WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, UserTypeData) > 0;
        }

        public static bool Delete(int UserTypeID)
        {
            string Query = @"DELETE FROM [UsersTypes] WHERE UserTypeID = @UserTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@UserTypeID", UserTypeID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static List<clsUserTypeData> GetUsersTypes()
        {
            string Query = @"SELECT * FROM UsersTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsUserTypeData>(Command);

            }, Query);
        }

        public static bool IsExist(int UserTypeID)
        {
            string Query = @"SELECT R = 1 FROM UsersTypes WHERE UserTypeID = @UserTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@UserTypeID", UserTypeID)) != null;
        }
    }
}
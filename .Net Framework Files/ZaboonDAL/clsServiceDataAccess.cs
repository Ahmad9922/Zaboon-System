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
    public static class clsServiceDataAccess
    {
        public class clsServiceData
        {
            public int? ServiceID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }
            public decimal? Fees { get; set; }
        }

        public static bool GetByID(clsServiceData ServiceData)
        {
            string Query = "SELECT * FROM Services WHERE ServiceID = @ServiceID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceData);

            }, Query, new SqlParameter("@ServiceID", ServiceData.ServiceID));
        }

        public static int Add(clsServiceData ServiceData)
        {
            string Query = @"INSERT INTO [dbo].[Services] ( 
[Name], [Description], [IsActive], [Fees])
 VALUES ( @Name, @Description, @IsActive, @Fees)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceData);
        }

        public static bool Update(clsServiceData ServiceData)
        {
            string Query = @"UPDATE [dbo].[Services] SET 
[Name] = @Name,
[Description] = @Description,
[IsActive] = @IsActive,
[Fees] = @Fees WHERE ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ServiceData) > 0;
        }

        public static bool Delete(int ServiceID)
        {
            string Query = @"DELETE FROM [Services] WHERE ServiceID = @ServiceID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static List<clsServiceData> GetServices()
        {
            string Query = @"SELECT * FROM Services";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceData>(Command);

            }, Query);
        }

        public static List<clsServiceData> GetServices(string Name)
        {
            string Query = @"SELECT * FROM Services WHERE Name = @Name";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceData>(Command);

            }, Query, new SqlParameter("@Name", Name));
        }

        public static bool IsExist(int ServiceID)
        {
            string Query = @"SELECT R = 1 FROM Services WHERE ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID)) != null;
        }

    }
}
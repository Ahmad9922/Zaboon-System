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
            public string Description { get; set; }
            public string Image { get; set; }
            public DateTime CreateDate { get; set; }
            public int ServiceTypeID { get; set; }

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
[Description], [Image], [CreateDate], [ServiceTypeID])
 VALUES ( @Description, @Image, @CreateDate, @ServiceTypeID)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceData);
        }

        public static bool Update(clsServiceData ServiceData)
        {
            string Query = @"UPDATE [dbo].[Services] SET 
[Description] = @Description,
[Image] = @Image,
[CreateDate] = @CreateDate,
[ServiceTypeID] = @ServiceTypeID WHERE ServiceID = @ServiceID";

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
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
    public static class clsServiceTypeDataAccess
    {
        public class clsServiceTypeData
        {
            public int? ServiceTypeID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }

        }


        public static bool GetByID(clsServiceTypeData ServiceTypeData)
        {
            string Query = "SELECT * FROM ServicesTypes WHERE ServiceTypeID = @ServiceTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceTypeData);

            }, Query, new SqlParameter("@ServiceTypeID", ServiceTypeData.ServiceTypeID));
        }

        public static int Add(clsServiceTypeData ServiceTypeData)
        {
            string Query = @"INSERT INTO [dbo].[ServicesTypes] ( 
[Name], [Description], [IsActive])
 VALUES ( @Name, @Description, @IsActive)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceTypeData);
        }

        public static bool Update(clsServiceTypeData ServiceTypeData)
        {
            string Query = @"UPDATE [dbo].[ServicesTypes] SET 
[Name] = @Name,
[Description] = @Description,
[IsActive] = @IsActive WHERE ServiceTypeID = @ServiceTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ServiceTypeData) > 0;
        }

        public static bool Delete(int ServiceTypeID)
        {
            string Query = @"DELETE FROM [ServicesTypes] WHERE ServiceTypeID = @ServiceTypeID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ServiceTypeID", ServiceTypeID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM ServicesTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ServicesTypes";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static bool IsExist(int ServiceTypeID)
        {
            string Query = @"SELECT R = 1 FROM ServicesTypes WHERE ServiceTypeID = @ServiceTypeID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceTypeID", ServiceTypeID)) != null;
        }

    }
}
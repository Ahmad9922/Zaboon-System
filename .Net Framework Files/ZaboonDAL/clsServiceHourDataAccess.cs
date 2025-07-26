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
    public static class clsServiceHourDataAccess
    {
        public class clsServiceHourData
        {
            public int? ServiceHourID { get; set; }
            public string Title { get; set; }
            public TimeSpan WorkStartTime { get; set; }
            public TimeSpan WorkEndTime { get; set; }
            public byte DayOfWeek { get; set; }
            public int ServiceID { get; set; }

        }

        public static bool GetByID(clsServiceHourData ServiceHourData)
        {
            string Query = "SELECT * FROM ServiceHours WHERE ServiceHourID = @ServiceHourID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, ServiceHourData);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourData.ServiceHourID));
            
        }

        public static int Add(clsServiceHourData ServiceHourData)
        {
            string Query = @"INSERT INTO [dbo].[ServiceHours] ( 
[Title], [WorkStartTime], [WorkEndTime], [DayOfWeek], [ServiceID])
 VALUES (@Title, @WorkStartTime, @WorkEndTime, @DayOfWeek, @ServiceID)
 SELECT SCOPE_IDENTITY();";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return Convert.ToInt32(clsAdoQueryExecutor.ExecuteScalar(Command));

            }, Query, ServiceHourData);
        }

        public static bool Update(clsServiceHourData ServiceHourData)
        {
            string Query = @"UPDATE [dbo].[ServiceHours] SET 
[Title] = @Title,
[WorkStartTime] = @WorkStartTime,
[WorkEndTime] = @WorkEndTime,
[DayOfWeek] = @DayOfWeek,
[ServiceID] = @ServiceID WHERE ServiceHourID = @ServiceHourID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, ServiceHourData) > 0;
        }

        public static bool Delete(int ServiceHourID)
        {
            string Query = @"DELETE FROM [ServiceHours] WHERE ServiceHourID = @ServiceHourID;";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteNonQuery(Command);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourID)) > 0;
        }

        public static DataTable GetList()
        {
            string Query = @"SELECT * FROM ServiceHours";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command);

            }, Query);
        }

        public static DataTable GetList(clsDataTypes.clsFilterData FilterData)
        {
            string Query = @"SELECT * FROM ServiceHours";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader(Command, FilterData);

            }, Query);
        }

        public static List<clsServiceHourData> GetServiceHours()
        {
            string Query = @"SELECT * FROM ServiceHours";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query);
        }

        public static List<clsServiceHourData> GetServiceHours(int ServiceID)
        {
            string Query = @"SELECT * FROM ServiceHours WHERE ServiceID = @ServiceID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query, new SqlParameter("@ServiceID", ServiceID));
        }

        public static List<clsServiceHourData> GetServiceHours(string Name)
        {
            string Query = @"SELECT ServiceHours.*
                             FROM ServiceHours INNER JOIN
                             Services ON ServiceHours.ServiceID = Services.ServiceID
                             WHERE Services.Name = @Name";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteReader<clsServiceHourData>(Command);

            }, Query, new SqlParameter("@Name", Name));
        }

        public static bool IsExist(int ServiceHourID)
        {
            string Query = @"SELECT R = 1 FROM ServiceHours WHERE ServiceHourID = @ServiceHourID";

            return clsAdoQueryExecutor.ExecuteQuery(Command =>
            {
                return clsAdoQueryExecutor.ExecuteScalar(Command);

            }, Query, new SqlParameter("@ServiceHourID", ServiceHourID)) != null;
        }

    }
}
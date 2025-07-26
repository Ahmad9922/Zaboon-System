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
    public class clsServiceHour
    {
        public event Action AfterDeleted;

        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public int? ServiceHourID { get; set; }
        public string Title { get; set; }
        public TimeSpan WorkStartTime { get; set; }
        public TimeSpan WorkEndTime { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int ServiceID { get; set; }
        public enMode Mode { get; private set; }

        private clsServiceHour(int ServiceID)
        {
            this.ServiceHourID = null;
            this.Title = null;
            this.WorkStartTime = new TimeSpan(0, 0, 0);
            this.WorkEndTime = new TimeSpan(0, 0, 0);
            this.DayOfWeek = DayOfWeek.Sunday;
            this.ServiceID = ServiceID;

            this.Mode = enMode.AddNew;
        }

        private clsServiceHour(TimeSpan WorkStartTime, TimeSpan WorkEndTime, DayOfWeek DayOfWeek, int ServiceID)
        {
            this.ServiceHourID = null;
            this.Title = null;
            this.WorkStartTime = WorkStartTime;
            this.WorkEndTime = WorkEndTime;
            this.DayOfWeek = DayOfWeek;
            this.ServiceID = ServiceID;

            this.Mode = enMode.AddNew;
        }

        private clsServiceHour(clsServiceHourDataAccess.clsServiceHourData ServiceHourData)
        {
            this.ServiceHourID = ServiceHourData.ServiceHourID;
            this.Title = ServiceHourData.Title;
            this.WorkStartTime = ServiceHourData.WorkStartTime;
            this.WorkEndTime = ServiceHourData.WorkEndTime;
            this.DayOfWeek = (DayOfWeek)ServiceHourData.DayOfWeek;
            this.ServiceID = ServiceHourData.ServiceID;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData();

            ServiceHourData.ServiceHourID = ServiceHourID;
            ServiceHourData.Title = Title;
            ServiceHourData.WorkStartTime = WorkStartTime;
            ServiceHourData.WorkEndTime = WorkEndTime;
            ServiceHourData.DayOfWeek = Convert.ToByte(DayOfWeek);
            ServiceHourData.ServiceID = ServiceID;

            this.ServiceHourID = clsServiceHourDataAccess.Add(ServiceHourData);

            return this.ServiceHourID != null;
        }

        private bool _Update()
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData();

            ServiceHourData.ServiceHourID = ServiceHourID;
            ServiceHourData.Title = Title;
            ServiceHourData.WorkStartTime = WorkStartTime;
            ServiceHourData.WorkEndTime = WorkEndTime;
            ServiceHourData.DayOfWeek = Convert.ToByte(DayOfWeek);
            ServiceHourData.ServiceID = ServiceID;

            return clsServiceHourDataAccess.Update(ServiceHourData);
        }

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

        public bool Delete()
        {
            bool IsSuccessful = false;

            if (this.ServiceHourID != null)
            {
                IsSuccessful = clsServiceHourDataAccess.Delete(this.ServiceHourID.Value);

                if (IsSuccessful)
                {
                    AfterDeleted?.Invoke();
                }

            }

            return IsSuccessful;
        }

        public static clsServiceHour Find(int ServiceHourID)
        {
            clsServiceHourDataAccess.clsServiceHourData ServiceHourData = new clsServiceHourDataAccess.clsServiceHourData();

            ServiceHourData.ServiceHourID = ServiceHourID;

            if (clsServiceHourDataAccess.GetByID(ServiceHourData))
            {
                return new clsServiceHour(ServiceHourData);
            }
            else
            {
                return null;
            }
        }

        public static clsServiceHour Add(TimeSpan WorkStartTime, TimeSpan WorkEndTime, DayOfWeek DayOfWeek, int ServiceID)
        {
            bool ValidateWorkStartTime = WorkStartTime >= TimeSpan.Zero && WorkStartTime <= new TimeSpan(23, 59, 59);
            bool ValidateWorkEndTime = WorkEndTime >= TimeSpan.Zero && WorkEndTime <= new TimeSpan(23, 59, 59);

            if (ValidateWorkStartTime && ValidateWorkEndTime)
            {
                return new clsServiceHour(WorkStartTime, WorkEndTime, DayOfWeek, ServiceID);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ServiceHourID)
        {
            return clsServiceHourDataAccess.IsExist(ServiceHourID);
        }

        public static bool Delete(int ServiceHourID)
        {
            return clsServiceHourDataAccess.Delete(ServiceHourID);
        }

        public static DataTable GetList()
        {
            return clsServiceHourDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceHourDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        public static List<clsServiceHour> GetServiceHours()
        {
            return clsServiceHourDataAccess.GetServiceHours().Select(S => new clsServiceHour(S)).ToList();
        }

        public static List<clsServiceHour> GetServiceHours(int ServiceID)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceID).Select(S => new clsServiceHour(S)).ToList();
        }

        public static List<clsServiceHour> GetServiceHours(string ServiceName)
        {
            return clsServiceHourDataAccess.GetServiceHours(ServiceName)?.Select(S => new clsServiceHour(S)).ToList();
        }

        public override string ToString()
        {
            return $"{Title} {WorkStartTime} - {WorkEndTime} ({DayOfWeek})";
        }

        public override bool Equals(object obj)
        {
            return ServiceHourID.Equals((obj as clsServiceHour).ServiceHourID);
        }
    }
}
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
    public class clsReservation
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public enum enReservationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }

        public int? ReservationID { get; set; }
        public clsUser User { get; set; }
        public DateTime ReservationDate { get; set; }
        public enReservationStatus ReservationStatus { get; set; }
        public decimal? PaidFees { get; set; }
        public clsService Service { get; set; }
        public clsServiceHour ServiceHour { get; set; }
        public DateTime CreateDate { get; set; }
        public enMode Mode { get; private set; }

        private clsReservation(clsUser User, clsService Service, clsServiceHour ServiceHour)
        {
            ReservationID = null;

            this.User = User;
            this.Service = Service;
            this.ServiceHour = ServiceHour;

            ReservationDate = DateTime.Now;
            ReservationStatus = enReservationStatus.New;
            PaidFees = null;
            CreateDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }

        private clsReservation(clsReservationDataAccess.clsReservationData ReservationData)
        {
            ReservationID = ReservationData.ReservationID;
            User = clsUser.Find(ReservationData.UserID);
            ReservationDate = ReservationData.ReservationDate;
            ReservationStatus = (enReservationStatus)ReservationData.ReservationStatus;
            PaidFees = ReservationData.PaidFees;
            Service = clsService.Find(ReservationData.ServiceID);
            ServiceHour = clsServiceHour.Find(ReservationData.ServiceHourID);
            CreateDate = ReservationData.CreateDate;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;
            ReservationData.UserID = User.UserID.Value;
            ReservationData.ReservationDate = ReservationDate;
            ReservationData.ReservationStatus = Convert.ToByte(ReservationStatus);
            ReservationData.PaidFees = PaidFees;
            ReservationData.ServiceID = Service.ServiceID.Value;
            ReservationData.ServiceHourID = ServiceHour.ServiceHourID.Value;

            this.ReservationID = clsReservationDataAccess.Add(ReservationData);

            return this.ReservationID != null;
        }

        private bool _Update()
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;
            ReservationData.UserID = User.UserID.Value;
            ReservationData.ReservationDate = ReservationDate;
            ReservationData.ReservationStatus = Convert.ToByte(ReservationStatus);
            ReservationData.PaidFees = PaidFees;
            ReservationData.ServiceID = Service.ServiceID.Value;
            ReservationData.ServiceHourID = ServiceHour.ServiceHourID.Value;

            return clsReservationDataAccess.Update(ReservationData);
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
            return clsReservationDataAccess.Delete(ReservationID.Value);
        }

        public static clsReservation Find(int ReservationID)
        {
            clsReservationDataAccess.clsReservationData ReservationData = new clsReservationDataAccess.clsReservationData();

            ReservationData.ReservationID = ReservationID;

            if (clsReservationDataAccess.GetByID(ReservationData))
            {
                return new clsReservation(ReservationData);
            }
            else
            {
                return null;
            }
        }

        public static clsReservation Add(clsUser User, clsService Service, clsServiceHour ServiceHour)
        {
            if (User != null && Service != null)
            {
                return new clsReservation(User, Service, ServiceHour);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int ReservationID)
        {
            return clsReservationDataAccess.Delete(ReservationID);
        }

        public static bool IsExist(int ReservationID)
        {
            return clsReservationDataAccess.IsExist(ReservationID);
        }

        public static DataTable GetList()
        {
            return clsReservationDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsReservationDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        public static List<clsReservation> GetReservations()
        {
            return clsReservationDataAccess.GetReservations().Select(R => new clsReservation(R)).ToList();
        }

        public static List<clsReservation> GetReservations(int UserID)
        {
            return clsReservationDataAccess.GetReservations(UserID).Select(R => new clsReservation(R)).ToList();
        }

        public static List<clsReservation> GetReservations(int UserID, int ServiceID)
        {
            return clsReservationDataAccess.GetReservations(UserID, ServiceID).Select(R => new clsReservation(R)).ToList();
        }

        public static List<clsReservation> GetCurrentServiceHourReservations(int ServiceID)
        {
            return clsReservationDataAccess.GetCurrentServiceHourReservations(ServiceID).Select(R => new clsReservation(R)).ToList();
        }
    }
}
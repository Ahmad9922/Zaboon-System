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
    public class clsService
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public int? ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public decimal? Fees { get; set; }
        public enMode Mode { get; private set; }

        private clsService(string Name)
        {
            this.Name = Name;

            ServiceID = null;
            Description = null;
            Fees = null;

            IsActive = true;

            this.Mode = enMode.AddNew;
        }

        private clsService(clsServiceDataAccess.clsServiceData ServiceData)
        {
            ServiceID = ServiceData.ServiceID;
            Name = ServiceData.Name;
            Description = ServiceData.Description;
            IsActive = ServiceData.IsActive;
            Fees = ServiceData.Fees;

            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;
            ServiceData.Name = Name;
            ServiceData.Description = Description;
            ServiceData.IsActive = IsActive;
            ServiceData.Fees = Fees;

            this.ServiceID = clsServiceDataAccess.Add(ServiceData);

            return this.ServiceID != null;
        }

        private bool _Update()
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;
            ServiceData.Name = Name;
            ServiceData.Description = Description;
            ServiceData.IsActive = IsActive;
            ServiceData.Fees = Fees;

            return clsServiceDataAccess.Update(ServiceData);
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
            return clsServiceDataAccess.Delete(ServiceID.Value);
        }

        public static clsService Find(int ServiceID)
        {
            clsServiceDataAccess.clsServiceData ServiceData = new clsServiceDataAccess.clsServiceData();

            ServiceData.ServiceID = ServiceID;

            if (clsServiceDataAccess.GetByID(ServiceData))
            {
                return new clsService(ServiceData);
            }
            else
            {
                return null;
            }
        }

        public static clsService Add(string Name)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                return new clsService(Name);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int ServiceID)
        {
            return clsServiceDataAccess.IsExist(ServiceID);
        }

        public static bool Delete(int ServiceID)
        {
            return clsServiceDataAccess.Delete(ServiceID);
        }

        public static DataTable GetList()
        {
            return clsServiceDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsServiceDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        private static List<clsService> _GetServices(List<clsServiceDataAccess.clsServiceData> ServicesData)
        {
            List<clsService> Services = new List<clsService>();

            foreach (clsServiceDataAccess.clsServiceData ServiceData in ServicesData)
            {
                Services.Add(new clsService(ServiceData));
            }

            return Services;
        }

        public static List<clsService> GetServices()
        {
            return _GetServices(clsServiceDataAccess.GetServices());
        }

        public static List<clsService> GetServices(string Name)
        {
            return _GetServices(clsServiceDataAccess.GetServices(Name));
        }
    }
}
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
    public class clsUserType
    {
        public enum enUserTypeID
        {
            Client = 1,
            Employee = 2
        }

        public enUserTypeID UserTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private clsUserType(clsUserTypeDataAccess.clsUserTypeData UserTypeData)
        {
            UserTypeID = (enUserTypeID)UserTypeData.UserTypeID;
            Name = UserTypeData.Name;
            Description = UserTypeData.Description;
        }

        private bool _Update()
        {
            clsUserTypeDataAccess.clsUserTypeData UserTypeData = new clsUserTypeDataAccess.clsUserTypeData();

            UserTypeData.UserTypeID = Convert.ToInt32(UserTypeID);
            UserTypeData.Name = Name;
            UserTypeData.Description = Description;

            return clsUserTypeDataAccess.Update(UserTypeData);
        }

        public bool Save()
        {
            return _Update();
        }

        public static clsUserType Find(enUserTypeID UserTypeID)
        {
            clsUserTypeDataAccess.clsUserTypeData UserTypeData = new clsUserTypeDataAccess.clsUserTypeData();

            UserTypeData.UserTypeID = Convert.ToInt32(UserTypeID);

            if (clsUserTypeDataAccess.GetByID(UserTypeData))
            {
                return new clsUserType(UserTypeData);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(enUserTypeID UserTypeID)
        {
            return clsUserTypeDataAccess.IsExist(Convert.ToInt32(UserTypeID));
        }

        public static DataTable GetList()
        {
            return clsUserTypeDataAccess.GetList();
        }

        public static DataTable GetList(string Value, string FieldName)
        {
            return clsUserTypeDataAccess.GetList(new clsDataTypes.clsFilterData(Value, FieldName));
        }

        public static List<clsUserType> GetUserTypes()
        {
            List<clsUserTypeDataAccess.clsUserTypeData> UsersTypesData = clsUserTypeDataAccess.GetUsersTypes();

            List<clsUserType> UsersTypes = new List<clsUserType>();

            foreach (clsUserTypeDataAccess.clsUserTypeData UserTypeData in UsersTypesData)
            {
                UsersTypes.Add(new clsUserType(UserTypeData));
            }

            return UsersTypes;
        }
    }
}
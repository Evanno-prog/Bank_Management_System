using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem_DataAccessLayer;
namespace BankSystem_BussinnesLayer
{
    public class clsUsers : clsPersones
    {
//     For Permissions Code, Later on, when you prepare Presentation layer WinForm,
//     Write there Method and fun as needed in preLayer and BussLayer :-)
        public enum enPermissions {eAll= -1,pManageClient=0,pManageUsers, pTransactionClient }

        private enum enMode { AddNew, Update };
        private enMode _Mode = enMode.AddNew;
        public int UserID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short  Permissions { get; set; }
        private new int Persone_id { get; set; }
        public clsUsers() : base()
        {
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            Permissions = 0;
            Persone_id = 0;
            _Mode = enMode.AddNew;
        }

        private clsUsers(int UserID, string UserName, string Password, short Permissions, int Persone_id, string FirstName, string LastName, string Email, string Phone)
            : base(Persone_id, FirstName, LastName, Email, Phone)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
            this.Persone_id = Persone_id;
            _Mode = enMode.Update;
        }

        public static clsUsers Find(string UserName)
        {

            string Password = "";
            short Permissions = 0;
            int Persone_id = 0, User_id = 0;

            if (clsUserData.GetUserInfoByUserName(UserName, ref User_id, ref Password, ref Permissions, ref Persone_id)) 
            {
                clsPersones Per = clsPersones.Find(Persone_id);
                return new clsUsers(User_id, UserName, Password, Permissions, Persone_id, Per.FirstName, Per.LastName, Per.Email, Per.Phone);
            }
            else
                return null;
        }

        private bool _AddNewUser()
        {
            if (base.Save())
            {
                this.UserID = clsUserData.AddNewUser(UserName, Password, Permissions, Persone_id);
                return (this.UserID != -1);
            }
            else { return false; }
        }

        private bool _UpdateUser()
        {
            if (base.Save())
            {
                return clsUserData.UpdateUser(UserName, Password, Permissions);
            }
            else
                return false;
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }
  
        public static bool DeleteUser(string UserName)
        {

            clsUsers User = Find(UserName);
            int personID = User.Persone_id;

            if (clsUserData.DeleteUser(UserName))
            {
                return clsPersonesData.DeletePersone(personID);
            }

            return false;

        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
    


    }
}

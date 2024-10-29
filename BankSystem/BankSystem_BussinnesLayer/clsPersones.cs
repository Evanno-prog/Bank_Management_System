using BankSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_BussinnesLayer
{
    public class clsPersones
    {

        private enum enMode { AddNew, Update };

        private enMode _Mode = enMode.AddNew;
        public int Persone_id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        protected clsPersones()
        {
            Persone_id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            _Mode = enMode.AddNew;
        }

        protected clsPersones(int Persone_id, string FirstName, string LastName, string Email, string Phone)
        {
            this.Persone_id = Persone_id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            _Mode = enMode.Update;
        }

        protected static clsPersones Find(int ID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "";

            if (clsPersonesData.GetPersoneInfoById(ID, ref FirstName, ref LastName, ref Email, ref Phone)) 
            {
                return new clsPersones(ID, FirstName, LastName, Email, Phone);
            }
            else
                return null;
        }

        private bool _AddNewPersone()
        {
            Persone_id = clsPersonesData.AddNewPersone(FirstName, LastName, Email, Phone);
            return (Persone_id != -1);
        }

        private bool _UpdatePersone()
        {
            return clsPersonesData.UpdatePersone(Persone_id, FirstName, LastName, Email, Phone);
        }
        protected bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPersone())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                
                case enMode.Update:
                    return _UpdatePersone();
                
            }
            return false;
        }

    }
}


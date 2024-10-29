using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BankSystem_DataAccessLayer;
namespace BankSystem_BussinnesLayer
{
    public class clsClients : clsPersones
    {
        
        private enum enMode { AddNew, Update};

        private enMode _Mode = enMode.AddNew;
        private int ClientID { get; set; }
        public string AccountNumber { get; set; }   
        public string PinCode { get; set; }
        public int Balance { get; set; }

        private new int Persone_id { get; set; }
        public clsClients() : base()
        {
            ClientID = -1;
            AccountNumber = string.Empty;
            PinCode = string.Empty;
            Balance = 0;
            Persone_id = 0;
            _Mode = enMode.AddNew;
        }

        private clsClients(int ClientID, string AccountNumber, string PinCode, int Balance, int Persone_id, string FirstName, string LastName, string Email, string Phone)
            : base(Persone_id, FirstName, LastName, Email, Phone)
        {
            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.Balance = Balance;
            this.Persone_id = Persone_id;
            _Mode = enMode.Update;
        }

        public static clsClients Find(string AccNumber)
        {
            string PinCode = "";
            int Balance = 0, Persone_id = 0, Client_id = 0;


            if (clsClientsData.GetClientByAccountNumber(AccNumber,ref Client_id, ref PinCode, ref Balance, ref Persone_id))
            {    
                clsPersones Persone = clsPersones.Find(Persone_id);

                return new clsClients(Client_id, AccNumber, PinCode, Balance, Persone_id, Persone.FirstName, Persone.LastName,Persone.Email, Persone.Phone);
            }
            else 
                return null;
        }
        
        private bool _AddNewClient()
        {
            if (base.Save())
            {
                ClientID = clsClientsData.AddNewClient(AccountNumber, PinCode, Balance, Persone_id);
                return (ClientID != -1);
            }
            else { return false; }
        }

        private bool _UpdateClient()
        {
            if (base.Save())
            {
                return clsClientsData.UpdateClient(ClientID, PinCode, Balance);
            }
            else
                return false;
        }
        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                   
                case enMode.Update:
                    return _UpdateClient();
          
            }
            return false;
        }
    
        public static bool IsClientExist(string AccountNumber)
        {
            return clsClientsData.IsClientExist(AccountNumber);
        }
        public static bool DeleteClient(string AccountNumber)
        {

            clsClients Client = Find(AccountNumber);
            int personID = Client.Persone_id;

            if (clsClientsData.DeleteClient(AccountNumber))
            {
                return clsPersonesData.DeletePersone(personID);
            }

            return false;
        }
 
        public static DataTable GetAllClients()
        {
            return clsClientsData.GetAllClients();
        }
   
    }
}

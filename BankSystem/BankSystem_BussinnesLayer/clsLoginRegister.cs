using BankSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_BussinnesLayer
{
    public class clsLoginRegister
    {
      
        public static bool AddLoginRegister(int User_id)
        {
          
            DateTime LogDate = DateTime.Now;
            return clsLoginRegisterData.AddLoginRegister(User_id, LogDate);
        }

        public static DataTable GetAllLoginRegisters()
        {
            return clsLoginRegisterData.GetAllLoginRegisters();
        }

    }
}

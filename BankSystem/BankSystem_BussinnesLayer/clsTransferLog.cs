using BankSystem_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_BussinnesLayer
{
    public class clsTransferLog
    {
        public static bool AddTransferLog(int S_Client,int D_Client,float Amount,int User_id)
        {
            DateTime LogDate = DateTime.Now;
            return clsTransferLogData.AddTransferLog(S_Client, D_Client, Amount, LogDate, User_id);
        }


        public static DataTable GetAllTransferLogs()
        {
            return clsTransferLogData.GetAllTransferLogs();
        }
    }
}

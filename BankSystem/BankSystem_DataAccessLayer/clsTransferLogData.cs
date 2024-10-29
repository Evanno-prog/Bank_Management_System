using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_DataAccessLayer
{
    public static class clsTransferLogData
    {
        public static bool AddTransferLog(int S_Client, int D_Client, float Amount, DateTime LogDate, int User_id)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into TransferLogs(SourceClient_id,DestinationClient_id,Amount,Date,User_id)
                           Values(@S_Client, @D_Client, @Amount, @LogDate, @User_id)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@S_Client", S_Client);
            command.Parameters.AddWithValue("@D_Client", D_Client);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@LogDate", LogDate);
            command.Parameters.AddWithValue("@User_id", User_id);

            int RowsAffected = 0;

            try
            {

                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }
            finally { connection.Close(); }

            return (RowsAffected > 0);

        }
    
        public static DataTable GetAllTransferLogs()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ListTransferLogs";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;


        }
    }
}

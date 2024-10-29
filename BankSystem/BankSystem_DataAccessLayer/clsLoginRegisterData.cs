using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_DataAccessLayer
{
    public static class clsLoginRegisterData
    {
        public static bool AddLoginRegister(int User_id,DateTime LogDate)
        {
           
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into LoginRegisters(LogDate,  User_id)
                           Values(@LogDate,  @User_id)";
            SqlCommand command = new SqlCommand(Query, connection);
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
  
        public static DataTable GetAllLoginRegisters() 
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LoginRegisterInfo";

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

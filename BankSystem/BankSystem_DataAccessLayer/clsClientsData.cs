using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Net;
using System.Data;

namespace BankSystem_DataAccessLayer
{
    public static class clsClientsData
    {
        public static bool GetClientByAccountNumber(string AccountNumber,ref int Client_id , ref string PinCode, ref int Balance, ref int Persone_id)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Clients where AccountNumber = @AccountNumber";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Client_id = (int)reader["Client_id"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (int)reader["Balance"];
                    Persone_id = (int)reader["Persone_id"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
            }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int AddNewClient(string AccountNumber, string PinCode, int Balance, int Persone_id)
        {
            int Client_id = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Clients( AccountNumber,  PinCode,  Balance,  Persone_id)
                           Values(@AccountNumber,  @PinCode,  @Balance,  @Persone_id)
                           select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@Persone_id", Persone_id);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    Client_id = insertedID;
                }

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return Client_id;

        }
        public static bool UpdateClient(int Client_id, string PinCode, int Balance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Clients  
                            set PinCode = @PinCode, 
                                Balance = @Balance 
                                where Client_id = @Client_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Client_id", Client_id);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Balance", Balance);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }
        public static bool IsClientExist(string AccountNumber)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE AccountNumber = @AccNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;


        }
        public static bool DeleteClient(string AccountNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Clients 
                                where AccountNumber = @AccNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccountNumber);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ListClientsInfo";

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

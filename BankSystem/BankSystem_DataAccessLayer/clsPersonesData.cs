using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace BankSystem_DataAccessLayer
{
    public static class clsPersonesData
    {
        public static bool GetPersoneInfoById(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Persones where Persone_id = @Persone_id";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@Persone_id", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
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

        public static int AddNewPersone(string FirstName, string LastName, string Email, string Phone)
        {

            int Persone_id = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Persones(FirstName,LastName,Email,Phone)
                           Values(@FirstName,@LastName,@Email,@Phone)
                           select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int insertedID))
                {
                    Persone_id = insertedID;
                }

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return Persone_id;

        }

        public static bool UpdatePersone(int Persone_id, string FirstName, string LastName, string Email, string Phone)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Persones  
                            set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone
                                where Persone_id = @Persone_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Persone_id", Persone_id);

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
    
        public static bool DeletePersone(int Persone_id)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Persones 
                                where Persone_id = @Persone_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Persone_id", Persone_id);

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
    }
}

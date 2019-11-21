using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ExampleCon
{
   public class DataLayer
    {
        public void insertData(String UnEncrypted)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=ROHNNIE;Initial Catalog=EncryDecryDB;Integrated Security=True"))
            {

                connection.Open();

                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [UnEncrypted] WHERE ([Message] = @Message)", connection);
                check_User_Name.Parameters.AddWithValue("@Message", UnEncrypted);

                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    //Message exist
                    Console.WriteLine("Message Exists!"+ UnEncrypted);
                }
                else
                {
                    //Message doesn't exist.
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into UnEncrypted (EncryptedMessage) VALUES (@EncryptedMessage)";
                        command.Parameters.AddWithValue("@EncryptedMessage", UnEncrypted);
                        try
                        {
                           // connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            // error here
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
             
            }
        }

        public void insertData_(String Encrypted)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=ROHNNIE;Initial Catalog=EncryDecryDB;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [unEncrypted] WHERE ([Message] = @Message)", connection);
                check_User_Name.Parameters.AddWithValue("@Message", Encrypted);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    //Message exist

                    Console.WriteLine("Message Exists!" + Encrypted);
                }
                else
                {
                    //Message doesn't exist.

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into Encrypted (Message) VALUES (@Message)";
                        command.Parameters.AddWithValue("@Message", Encrypted);
                        try
                        {
                            
                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            // error here
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
               
    }
}

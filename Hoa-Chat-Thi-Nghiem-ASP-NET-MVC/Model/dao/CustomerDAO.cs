using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace Model.dao
{
    public class CustomerDAO
    {
        public CustomerDAO() { }

        public ArrayList getCustomers(string username)
        {
            string query = "select id_user_customer, username, pass, id_status_acc, id_city, " +
                "fullname from account_customer where username = @username";
            ArrayList result = new ArrayList();
            DBConnection connectDB = DBConnection.GetInstall(); // mở kết nối đến mysql
            try
            {
                MySqlCommand command = connectDB.GetMySqlCommand(); // đối tượng để thực thi câu lệnh sql
                command.CommandText = query;
                command.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int IdCustomer = reader.GetInt32("id_user_customer");
                        string Username = reader.GetString("username");
                        string Pass = reader.GetString("pass");
                        int IdStatusAcc = reader.GetInt32("id_status_acc");
                        int IdCity = reader.GetInt32("id_city");
                        string Fullname = null;
                        try
                        {
                            Fullname = reader.GetString("fullname");
                        }
                        catch (Exception e)
                        {
                            Fullname = Username;
                        }                           
                        Customer customer = new Customer(IdCustomer, Username, Pass, IdStatusAcc, IdCity, Fullname);
                        result.Add(customer);
                    }
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
            finally
            {
                connectDB.UnInstall(); // hủy kết nối
            }
            return result;
        }

        public bool checkExsit(string email)
        {
            DBConnection connectDB = DBConnection.GetInstall();
            string sql = "SELECT * FROM account_customer where username = @email";
            ArrayList result = new ArrayList();
            try
            {
                MySqlCommand command = connectDB.GetMySqlCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(1);
                    }
                }
                if(result.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(MySqlException e){
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }
        }

        public void register(string email, string password)
        {
            DBConnection connectDb = DBConnection.GetInstall();
            string sql = "INSERT INTO account_customer(username, pass, id_status_acc, id_city) " +
                "VALUES(@email, @password, 1, 1)";
            try
            {
                MySqlCommand command = connectDb.GetMySqlCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("password", password);
                command.ExecuteNonQuery();
            }
            catch (MySqlException e) 
            { 
                return;
            }
            finally
            {
                connectDb.UnInstall();
            }
        }
        public void changePass(string email, string newPass)
        {
            DBConnection connectDB = DBConnection.GetInstall();
            String sql = "UPDATE account_customer " +
                "SET pass = @newPass, time_change_pass = current_timestamp()" +
                " WHERE username = @email";
            try
            {
                MySqlCommand command = connectDB.GetMySqlCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@newPass", newPass);
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw new Exception("Loi xay ra");
            }
            finally{ 
                connectDB.UnInstall(); 
            }
        }
    }
}

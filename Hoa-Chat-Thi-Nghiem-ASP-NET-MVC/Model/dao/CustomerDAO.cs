using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Model.dao
{
    public class CustomerDAO
    {
        public CustomerDAO() { }

        public ArrayList getCustomers(string username)
        {
            string query = "select * from account_customer where username = @username";
            ArrayList result = new ArrayList();
            DBConnection connectDB = DBConnection.GetInstall(); // mở kết nối đến mysql
            try
            {
                MySqlCommand command = connectDB.GetMySqlCommand(); // đối tượng để thực thi câu lệnh sql
                command.CommandText = query;
                command.Parameters.AddWithValue("@username", username);
                connectDB.GetConnect().Open(); 
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
                        string Fullname = reader.GetString("fullname");
                        string Sex = reader.GetString("sex");
                        string Email = reader.GetString("email_customer");
                        string Phone = reader.GetString("phone_customer");
                        string Address = reader.GetString("address");
                        Customer customer = new Customer(IdCustomer, Username, Pass, IdStatusAcc, IdCity, Fullname, Sex, Email, Phone, Address);
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
    }
}

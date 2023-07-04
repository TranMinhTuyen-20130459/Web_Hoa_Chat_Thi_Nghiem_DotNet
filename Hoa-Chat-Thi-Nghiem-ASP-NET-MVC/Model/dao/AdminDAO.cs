
using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace Model.dao
{
    public class AdminDAO
    {

        public AdminDAO() { }

        public ArrayList ListAdmin(string username)
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            ArrayList result = new ArrayList();
            try
            {
                String stringQuery = "select username,passwordAD,id_role_admin,id_status_acc,fullname from account_admin where username = @username";
                MySqlCommand cmd = connectDB.GetMySqlCommand(); // tạo ra đối tượng command làm nhiệm vụ thực thi câu lệnh sql
                cmd.CommandText = stringQuery;
                cmd.Parameters.AddWithValue("@username", username);             
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String user = reader.GetString("username");
                        String pass = reader.GetString("passwordAD");
                        int id_role_admin = reader.GetInt32("id_role_admin");
                        int id_status_acc = reader.GetInt32("id_status_acc");
                        String fullname = reader.GetString("fullname");
                        Admin admin = new Admin(user, pass, id_role_admin, id_status_acc, fullname);
                        result.Add(admin);
                    }
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
            finally
            {
                connectDB.UnInstall();
            }
            return result;
        }

    }
}

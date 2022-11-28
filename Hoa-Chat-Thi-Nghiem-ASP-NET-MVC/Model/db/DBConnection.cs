using MySql.Data.MySqlClient;
using System;

namespace Model.db
{
    public class DBConnection
    {
        const String host = "127.0.0.1"; // -> localhost
        const int port = 3306;
        const String database = "hoa_chat_thi_nghiem";
        const String username = "root";
        const String pass = "";
        static DBConnection install;
        MySqlConnection connect;

        // chuỗi kết nối đến MySQL
        public static String connString()
        {
            return "Server=" + host + ";Database=" + database + ";port=" + port
                    + ";User Id=" + username + ";password=" + pass;
        }

        // đối tượng này chuyên dùng để kết nối đến CSDL
        public DBConnection()
        {
            connect = new MySqlConnection(DBConnection.connString());
        }

        public static DBConnection GetInstall()
        {
            if (install == null) install = new DBConnection();
            return install;
        }

        public void UnInstall()
        {
            connect.Close();
            install = null;
        }

        public MySqlConnection GetConnect()
        {
            return connect;
        }

        // tạo ra đối tượng để thực thi các câu lệnh SQL <-> tương đương PreparedStatement trong Java
        public MySqlCommand GetMySqlCommand()
        {
            if (connect == null) return null;
            return connect.CreateCommand();
        }
    }
}

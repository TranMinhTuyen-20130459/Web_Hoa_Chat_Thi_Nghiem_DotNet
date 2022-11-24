using MySql.Data.MySqlClient;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace ConnectDB
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bắt dầu kết nối CSDL Mysql ...");

            MySqlConnection conn = KetNoi.GetDBConnection();

            try
            {

                Console.WriteLine("Bắt đầu mở kết nối ...");

                conn.Open();

                Console.WriteLine("Kết nối thành công !");

            }

            catch (Exception e)
            {

                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);

            }

            Console.Read();

        }
    }
}
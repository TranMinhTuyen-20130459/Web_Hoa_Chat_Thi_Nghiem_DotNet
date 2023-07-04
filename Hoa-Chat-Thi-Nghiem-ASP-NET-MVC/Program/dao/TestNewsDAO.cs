using Model.dao;
using Model.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.dao
{
    public class TestNewsDAO
    {
        public static void TestGetNews()
        {
            NewsDAO dao = new NewsDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            Console.WriteLine(dao.getNews(connectDB));
        } 
    }
}

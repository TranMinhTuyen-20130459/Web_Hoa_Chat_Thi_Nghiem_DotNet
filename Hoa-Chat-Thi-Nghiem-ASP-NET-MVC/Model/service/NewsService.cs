using Model.dao;
using Model.db;
using Model.entity;
using System;

namespace Model.service
{
    public class NewsService
    {
        
        public static bool AddNews(News news, Admin admin)
        {
            DBConnection connectDB = DBConnection.GetInstall();
            NewsDAO dao = new NewsDAO();
            try
            {
                bool checkInsertNews = dao.insertNews(connectDB, news, admin.Username);
                if (checkInsertNews) return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }
            return false;
        }
    }
}

using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System;

namespace Model.dao
{
    public class NewsDAO
    {
        public NewsDAO() { }

        public bool insertNews(DBConnection connectDB, News news, string nameAdmin)
        {
            string stringQuery = "INSERT INTO news (title_news,content_news,nameAdmin) VALUES (@1,@2,@3)";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", news.Title);
                sqlCommand.Parameters.AddWithValue("@2", news.Content);
                sqlCommand.Parameters.AddWithValue("@3", nameAdmin);
                int rowInserted = sqlCommand.ExecuteNonQuery();
                if (rowInserted > 0) return true;
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
            return false;
        }

        public News getNews(DBConnection connectDB)
        {
            string sql = "select id_news,title_news,content_news,date_posted from news order by date_posted desc Limit 1;";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = sql;
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id_news");
                        string title = reader.GetString("title_news");
                        string content = reader.GetString("content_news");
                        DateTime date = reader.GetDateTime("date_posted");
                        News news = new News(id, title, content, date);
                        return news;
                    }
                }
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
            } 
            return null;
        }
    }
}

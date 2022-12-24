using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;

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
    }
}

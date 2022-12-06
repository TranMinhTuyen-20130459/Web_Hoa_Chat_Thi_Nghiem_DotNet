using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;

namespace Model.dao
{
    class ProductDAO
    {

        public ProductDAO() { }

        public bool insertProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            string stringQuery = "";
            MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
            sqlCommand.CommandText = stringQuery;

            return false;
        }

        public bool insertPriceProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            return false;
        }

        public int getIdProduct(DBConnection connectDB, Product p)
        {
            return 0;
        }

    }
}

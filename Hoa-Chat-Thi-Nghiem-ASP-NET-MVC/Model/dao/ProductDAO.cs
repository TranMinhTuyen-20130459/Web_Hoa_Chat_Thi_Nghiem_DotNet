using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Model.dao
{
    public class ProductDAO
    {

        public ProductDAO() { }

        public bool insertProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            string stringQuery = "insert into products(name_product,description_product,url_img_product,quantity_product,id_type_product,id_status_product,id_supplier,nameAdmin)" +
                " values (@1,@2,@3,@4,@5,@6,@7,@8)";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", p.Name_product);
                sqlCommand.Parameters.AddWithValue("@2", p.Desc_product);
                sqlCommand.Parameters.AddWithValue("@3", p.Url_img_product);
                sqlCommand.Parameters.AddWithValue("@4", p.Quantity_product);
                sqlCommand.Parameters.AddWithValue("@5", p.Id_type);
                sqlCommand.Parameters.AddWithValue("@6", p.Id_status);
                sqlCommand.Parameters.AddWithValue("@7", p.Id_supplier);
                sqlCommand.Parameters.AddWithValue("@8", nameAdmin);
                int rowInserted = sqlCommand.ExecuteNonQuery();
                if (rowInserted > 0) return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
            return false;
        }

        public bool insertPriceProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            string stringQuery = "insert into price_product(id_product,listed_price,current_price,nameAdmin)" +
                " values(@1,@2,@3,@4)";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", p.Id_product);
                sqlCommand.Parameters.AddWithValue("@2", p.Listed_price);
                sqlCommand.Parameters.AddWithValue("@3", p.Current_price);
                sqlCommand.Parameters.AddWithValue("@4", nameAdmin);
                int rowInserted = sqlCommand.ExecuteNonQuery();
                if (rowInserted > 0) return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
            return false;
        }

        public bool updateProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            string stringQuery = "UPDATE products" +
                                " SET name_product = @1, description_product = @2, url_img_product = @3, quantity_product = @4," +
                                " id_type_product = @5, id_status_product = @6, id_supplier = @7, nameAdmin = @8" +
                                " WHERE id_product = @9";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", p.Name_product);
                sqlCommand.Parameters.AddWithValue("@2", p.Desc_product);
                sqlCommand.Parameters.AddWithValue("@3", p.Url_img_product);
                sqlCommand.Parameters.AddWithValue("@4", p.Quantity_product);
                sqlCommand.Parameters.AddWithValue("@5", p.Id_type);
                sqlCommand.Parameters.AddWithValue("@6", p.Id_status);
                sqlCommand.Parameters.AddWithValue("@7", p.Id_supplier);
                sqlCommand.Parameters.AddWithValue("@8", nameAdmin);
                sqlCommand.Parameters.AddWithValue("@9", p.Id_product);
                int rowUpdated = sqlCommand.ExecuteNonQuery();
                if (rowUpdated > 0) return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
            return false;
        }

        public bool deleteProduct(DBConnection connectDB, Product p, string nameAdmin)
        {
            string stringQuery = "UPDATE products SET id_status_product = 5 WHERE id_product = @1";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", p.Id_product);
                int rowDeleted = sqlCommand.ExecuteNonQuery();
                if (rowDeleted > 0) return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
            return false;
        }

        public int getIdProduct(DBConnection connectDB, Product p)
        {
            string stringQuery = "SELECT id_product FROM products" +
                " WHERE name_product = @1 AND description_product = @2 AND url_img_product = @3" +
                " AND quantity_product = @4 AND id_type_product = @5 AND id_status_product = @6 AND id_supplier = @7";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                sqlCommand.Parameters.AddWithValue("@1", p.Name_product);
                sqlCommand.Parameters.AddWithValue("@2", p.Desc_product);
                sqlCommand.Parameters.AddWithValue("@3", p.Url_img_product);
                sqlCommand.Parameters.AddWithValue("@4", p.Quantity_product);
                sqlCommand.Parameters.AddWithValue("@5", p.Id_type);
                sqlCommand.Parameters.AddWithValue("@6", p.Id_status);
                sqlCommand.Parameters.AddWithValue("@7", p.Id_supplier);
                MySqlDataReader reader = sqlCommand.ExecuteReader(); // giống ResultSet bên Java
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetInt32("id_product");
                }
            }
            catch (MySqlException e)
            {
                return -1;
            }
            return 0;
        }

        public ArrayList getListTypeProduct(DBConnection connectDB)
        {
            ArrayList result = new ArrayList();
            string stringQuery = "SELECT id_type_product,name_type_product FROM type_product";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id_type = reader.GetInt32("id_type_product");
                        string name_type = reader.GetString("name_type_product");
                        TypeProduct tp = new TypeProduct(id_type, name_type);
                        result.Add(tp);
                    }
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
            return result;
        }

        public ArrayList getListStatusProduct(DBConnection connectDB)
        {
            ArrayList result = new ArrayList();
            string stringQuery = "SELECT id_status_product,name_status_product FROM status_product";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id_status = reader.GetInt32("id_status_product");
                        string name_status = reader.GetString("name_status_product");
                        StatusProduct sp = new StatusProduct(id_status, name_status);
                        result.Add(sp);
                    }
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
            return result;
        }

        public ArrayList getListSupplier(DBConnection connectDB)
        {
            ArrayList result = new ArrayList();
            string stringQuery = "SELECT id_supplier,name_supplier FROM suppliers";
            try
            {
                MySqlCommand sqlCommand = connectDB.GetMySqlCommand();
                sqlCommand.CommandText = stringQuery;
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id_supplier = reader.GetInt32("id_supplier");
                        string name_supplier = reader.GetString("name_supplier");
                        Supplier sl = new Supplier(id_supplier, name_supplier);
                        result.Add(sl);
                    }
                }
            }
            catch(MySqlException e)
            {
                return null;
            }

            return result;
        }



    }
}

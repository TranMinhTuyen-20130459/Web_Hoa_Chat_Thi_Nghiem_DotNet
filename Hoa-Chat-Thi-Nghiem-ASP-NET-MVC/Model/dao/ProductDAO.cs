using Model.db;
using Model.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;

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
                System.Console.WriteLine(e.Message);
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
                    int id = reader.GetInt32("id_product");
                    reader.Close();
                    return id;
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
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
                return result;
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
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
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
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.Message);
                return result;
            }

            return result;
        }

        public List<Product> findAll()
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<Product> result = new List<Product>();
            Product product = null;
            try
            {
                String query = "SELECT * FROM PRODUCTS AS P " +
                    "INNER JOIN TYPE_PRODUCT AS TP ON P.id_type_product = TP.id_type_product " +
                    "INNER JOIN STATUS_PRODUCT AS SP ON P.id_status_product = SP.id_status_product " +
                    "INNER JOIN price_product AS PP ON PP.id_product = P.id_product " +
                    "ORDER BY P.DATE_INSERTED DESC ";


                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product();

                        product.Name_product = reader.GetString("name_product");
                        product.Desc_product = reader.GetString("description_product");
                        product.Url_img_product = reader.GetString("url_img_product");
                        product.Id_product = reader.GetInt32("id_product");
                        product.Id_type = reader.GetInt32("id_type_product");
                        product.Id_type = reader.GetInt32("id_status_product");
                        product.Id_supplier = reader.GetInt32("id_supplier");
                        product.Quantity_product = reader.GetInt32("quantity_product");
                        product.Listed_price = reader.GetInt32("listed_price");
                        product.Current_price = reader.GetInt32("current_price");
                        product.Star = reader.GetInt32("star_review");

                        result.Add(product);
                    }

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


        public List<Product> findOneProductById(int id)
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<Product> result = new List<Product>();
            Product product = null;

            try
            {
                String query = "SELECT * FROM PRODUCTS AS P " +
                   "INNER JOIN TYPE_PRODUCT AS TP ON P.id_type_product = TP.id_type_product " +
                    "INNER JOIN STATUS_PRODUCT AS SP ON P.id_status_product = SP.id_status_product " +
                    "INNER JOIN price_product AS PP ON PP.id_product = P.id_product " +
                    "WHERE P.id_product = @id";

                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product();

                        product.Name_product = reader.GetString("name_product");
                        product.Desc_product = reader.GetString("description_product");
                        product.Url_img_product = reader.GetString("url_img_product");
                        product.Id_product = reader.GetInt32("id_product");
                        product.Id_type = reader.GetInt32("id_type_product");
                        product.Id_type = reader.GetInt32("id_status_product");
                        product.Id_supplier = reader.GetInt32("id_supplier");
                        product.Quantity_product = reader.GetInt32("quantity_product");
                        product.Star = reader.GetInt32("star_review");
                        product.Listed_price = reader.GetInt32("listed_price");
                        product.Current_price = reader.GetInt32("current_price");

                        result.Add(product);
                    }
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
        public List<Product> findProductsByIdType(int idType)
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<Product> result = new List<Product>();
            Product product = null;

            try
            {
                String query = "SELECT * FROM PRODUCTS AS P " +
                    "INNER JOIN TYPE_PRODUCT AS TP ON P.id_type_product = TP.id_type_product " +
                    "INNER JOIN STATUS_PRODUCT AS SP ON P.id_status_product = SP.id_status_product " +
                    "INNER JOIN price_product AS PP ON PP.id_product = P.id_product " +
                    "WHERE P.id_type_product = @id";


                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", idType);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product();

                        product.Name_product = reader.GetString("name_product");
                        product.Desc_product = reader.GetString("description_product");
                        product.Url_img_product = reader.GetString("url_img_product");
                        product.Id_product = reader.GetInt32("id_product");
                        product.Id_type = reader.GetInt32("id_type_product");
                        product.Id_type = reader.GetInt32("id_status_product");
                        product.Id_supplier = reader.GetInt32("id_supplier");
                        product.Quantity_product = reader.GetInt32("quantity_product");
                        product.Star = reader.GetInt32("star_review");
                        product.Listed_price = reader.GetInt32("listed_price");
                        product.Current_price = reader.GetInt32("current_price");

                        result.Add(product);
                    }
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
        public List<Product> findProductsByIdTypeMain(int idType)
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<Product> result = new List<Product>();
            Product product = null;

            try
            {
                String query = "SELECT * FROM PRODUCTS AS P " +
                    "INNER JOIN TYPE_PRODUCT AS TP ON P.id_type_product = TP.id_type_product " +
                    "INNER JOIN STATUS_PRODUCT AS SP ON P.id_status_product = SP.id_status_product " +
                    "INNER JOIN price_product AS PP ON PP.id_product = P.id_product " +
                    "WHERE P.id_type_product > @id AND P.id_type_product <= (@id + 10)";


                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", idType);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product();

                        product.Name_product = reader.GetString("name_product");
                        product.Desc_product = reader.GetString("description_product");
                        product.Url_img_product = reader.GetString("url_img_product");
                        product.Id_product = reader.GetInt32("id_product");
                        product.Id_type = reader.GetInt32("id_type_product");
                        product.Id_type = reader.GetInt32("id_status_product");
                        product.Id_supplier = reader.GetInt32("id_supplier");
                        product.Quantity_product = reader.GetInt32("quantity_product");
                        product.Star = reader.GetInt32("star_review");
                        product.Listed_price = reader.GetInt32("listed_price");
                        product.Current_price = reader.GetInt32("current_price");

                        result.Add(product);
                    }
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
        public List<TypeProduct> findAllTypeProducts()
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<TypeProduct> result = new List<TypeProduct>();
            TypeProduct type = null;

            try
            {
                String query = "SELECT * FROM type_product";

                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    type = new TypeProduct();

                    type.Id_type = reader.GetInt32("id_type_product");
                    type.Name_type = reader.GetString("name_type_product");


                    result.Add(type);
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
        public List<TypeProduct> findTypeProductsById(int id)
        {
            DBConnection connectDB = DBConnection.GetInstall(); // khởi tạo đối tượng kết nối đến MySql
            List<TypeProduct> result = new List<TypeProduct>();
            TypeProduct type = null;

            try
            {
                String query = "SELECT * FROM type_product " +
                    "WHERE id_type_product > @id AND id_type_product <= (@id + 10)";

                MySqlCommand cmd = connectDB.GetMySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    type = new TypeProduct();

                    type.Id_type = reader.GetInt32("id_type_product");
                    type.Name_type = reader.GetString("name_type_product");


                    result.Add(type);
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

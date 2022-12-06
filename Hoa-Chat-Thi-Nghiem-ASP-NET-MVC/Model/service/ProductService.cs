using Model.dao;
using Model.db;
using Model.entity;
using System;

namespace Model.service
{
    public class ProductService
    {

        public static bool addNewProduct(Product p, Admin admin)
        {
            /*
             * B1 : thêm tên,mô tả,hình ảnh,số lượng,mã loại,mã trạng thái,mã nhà cung cấp, tên tài khoản admin vào bảng products
             * B2 : lấy ra id_product dựa vào các thông tin ở B1 trên bảng products
             * B3 : thêm giá niêm yết,giá bán thực tế của sản phẩm dựa trên id_product vào bảng price_product
             */
            DBConnection connectDB = DBConnection.GetInstall();
            ProductDAO dao = new ProductDAO();
            try
            {
                bool checkInsertProduct = dao.insertProduct(connectDB, p, admin.Username);
                if (checkInsertProduct == true)
                {
                    int id_product_after_insert_product = dao.getIdProduct(connectDB, p);
                    p.Id_product = id_product_after_insert_product;
                    bool checkInsertPriceProduct = dao.insertPriceProduct(connectDB, p, admin.Username);

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }

            return false;
        }

        public static bool updateProduct(Product p, Admin admin)
        {
            DBConnection connectDB = DBConnection.GetInstall();
            ProductDAO dao = new ProductDAO();
            try
            {
                bool checkUpdateProduct = dao.updateProduct(connectDB, p, admin.Username);
                bool checkUpdatePrice = dao.insertPriceProduct(connectDB, p, admin.Username);
                if(checkUpdateProduct || checkUpdatePrice)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }
            return true;
        }

        public static bool deleteProduct(Product p, Admin admin)
        {
            DBConnection connectDB = DBConnection.GetInstall();
            ProductDAO dao = new ProductDAO();
            try
            {
                return dao.deleteProduct(connectDB, p, admin.Username);
            } 
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }
        }
    }
}

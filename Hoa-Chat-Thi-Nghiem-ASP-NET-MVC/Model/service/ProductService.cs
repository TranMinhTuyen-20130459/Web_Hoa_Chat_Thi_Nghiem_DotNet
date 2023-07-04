using Model.dao;
using Model.db;
using Model.entity;
using System;
using System.Collections;
using System.Collections.Generic;

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
                if (checkUpdateProduct || checkUpdatePrice)
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
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connectDB.UnInstall();
            }
        }

        public static ArrayList getListTypeStatusSupplier()
        {
            /*
             *B1: lấy ra danh sách các loại sản phẩm
             *B2: lấy ra danh sách các trạng thái sản phẩm
             *B3: lấy ra danh sách các nhà cung cấp
             *B4: thêm vào arraylist 
             */
            ArrayList result = new ArrayList();
            DBConnection connectDB = DBConnection.GetInstall();
            ProductDAO dao = new ProductDAO();
            try
            {
                ArrayList listType = dao.getListTypeProduct(connectDB);
                ArrayList listStatus = dao.getListStatusProduct(connectDB);
                ArrayList listSupplier = dao.getListSupplier(connectDB);
                result.Add(listType);
                result.Add(listStatus);
                result.Add(listSupplier);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connectDB.UnInstall();
            }
            return result;
        }
        public static List<Product> findAll()
        {
            ProductDAO dao = new ProductDAO();
            return dao.findAll();

        }
        public static List<Product> findOneProductById(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.findOneProductById(id);

        }
        public static List<Product> findProductsByIdType(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.findProductsByIdType(id);
        }
        public static List<Product> findProductsByIdTypeMain(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.findProductsByIdTypeMain(id);
        }
        public static List<TypeProduct> findTypeProducts()
        {
            ProductDAO dao = new ProductDAO();
            return dao.findAllTypeProducts();
        }
        public static List<TypeProduct> findTypeProductsById(int id)
        {
            ProductDAO dao = new ProductDAO();
            return dao.findTypeProductsById(id);
        }

    }
}

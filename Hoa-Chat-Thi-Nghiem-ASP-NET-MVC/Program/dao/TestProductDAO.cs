using System;
using Model.dao;
using Model.entity;
using Model.db;
using System.Collections;

namespace Program.dao
{
    public class TestProductDAO
    {
        public static void TestInsertProduct()
        {
            Product p = new Product("iphone 15", "siêu phẩm", "abcdef", 100, 2, 2, 2);
            ProductDAO dao = new ProductDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            Console.WriteLine(dao.insertProduct(connectDB, p, "tranminhtuyen"));
        }

        public static void TestInsertPriceProduct()
        {

            DBConnection connectDB = DBConnection.GetInstall();
            Product p = new Product(18, 200000, 198000);
            ProductDAO dao = new ProductDAO();
            Console.WriteLine(dao.insertPriceProduct(connectDB, p, "tuyen_kun"));
        }

        public static void TestUpdateProduct()
        {
            DBConnection connectDB = DBConnection.GetInstall();
            Product p = new Product("tuyentran", "tranminhtuyen", "/A/123", 1000, 2, 2, 2);
            p.Id_product = 1;
            ProductDAO dao = new ProductDAO();
            Console.WriteLine(dao.updateProduct(connectDB, p, "messi"));
        }

        public static void TestDeleteProduct()
        {
            ProductDAO dao = new ProductDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            Product p = new Product("tuyentran", "tranminhtuyen", "/A/123", 1000, 2, 2, 2);
            p.Id_product = 3;
            Console.WriteLine(dao.deleteProduct(connectDB, p, "tuyen_kun"));
        }

        public static void TestGetIdProduct()
        {

            ProductDAO dao = new ProductDAO();
            DBConnection connectDB_0 = DBConnection.GetInstall();
            Product p0 = new Product("iphone 4", "đây là sản phẩm thứ 2 của apple", "/HoaChatThiNghiem_war/DATA/gio-hang-figma.png", 100, 12, 5, 2);
            Console.WriteLine(dao.getIdProduct(connectDB_0, p0));
            connectDB_0.UnInstall();
            DBConnection connectDB_1 = DBConnection.GetInstall();
            Product p1 = new Product("iphone 15", "siêu phẩm", "abcdef", 100, 2, 2, 2);
            Console.WriteLine(dao.getIdProduct(connectDB_1, p1));

        }

        public static void TestGetListTypeProduct()
        {
            ProductDAO dao = new ProductDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            ArrayList listTypeProduct = dao.getListTypeProduct(connectDB);
            foreach (TypeProduct type in listTypeProduct)
            {
                Console.WriteLine(type);
            }
        }

        public static void TestGetListStatusProduct()
        {
            ProductDAO dao = new ProductDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            ArrayList listStatusProduct = dao.getListStatusProduct(connectDB);
            foreach (StatusProduct st in listStatusProduct)
            {
                Console.WriteLine(st);
            }


        }

        public static void TestGetListSupplier()
        {
            ProductDAO dao = new ProductDAO();
            DBConnection connectDB = DBConnection.GetInstall();
            ArrayList listSupplier = dao.getListSupplier(connectDB);
            foreach (Supplier sl in listSupplier)
            {
                Console.WriteLine(sl);
            }

        }
    }
}


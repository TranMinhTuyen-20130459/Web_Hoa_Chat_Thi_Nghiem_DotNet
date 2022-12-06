using System;
using Model.entity;
using Model.service;


namespace Program.service
{
    public class TestProductService
    {

        public static void TestAddNewProduct()
        {

            Product p_0 = new Product("IPHONE 14 PRO-MAX", "day la san pham cua apple", "/DATA/123.png", 100, 2, 2, 2, 200000, 198000);
            Product p_1 = new Product("IPHONE 15 PRO-MAX", "day la san pham cua apple", "/DATA/456.png", 1000, 1, 1, 3, 25000000, 19800000);
            Admin admin = new Admin("tuyen_kun", "tuyen123", 1, 1, "Tran Minh Tuyen");
            Console.WriteLine(ProductService.addNewProduct(p_0, admin));
            Console.WriteLine(ProductService.addNewProduct(p_1, admin));

        }

        public static void TestUpdateProduct()
        {
            Product p_1 = new Product("IPHONE 16 PRO", "day la san pham cua apple", "/DATA/456.png", 1000, 1, 1, 3, 15000000, 9800000);
            Admin admin = new Admin("tinh_kun", "tuyen123", 1, 1, "Tran Minh Tinh");
            p_1.Id_product = 36;
            Console.WriteLine(ProductService.updateProduct(p_1,admin));
        }

        public static void TestDeleteProduct()
        {
            Product p_1 = new Product("IPHONE 16 PRO", "day la san pham cua apple", "/DATA/456.png", 1000, 1, 1, 3, 15000000, 9800000);
            Admin admin = new Admin("tinh_kun", "tuyen123", 1, 1, "Tran Minh Tinh");
            p_1.Id_product = 36;
            Console.WriteLine(ProductService.deleteProduct(p_1,admin));
        }

    }
}

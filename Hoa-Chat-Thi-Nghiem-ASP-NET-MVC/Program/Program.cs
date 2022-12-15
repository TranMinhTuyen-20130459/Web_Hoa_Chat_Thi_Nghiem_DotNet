using Model.dao;
using Model.db;
using Model.entity;
using Model.service;
using System;
using System.Collections;
using System.Text;
using Program.dao;
using Program.service;

namespace Program
{
    class Program

    {
        static void TestConnectMySQL()
        {
            Console.WriteLine("Getting connection ...");
            try
            {
                Console.WriteLine("Open Connection ...");
                DBConnection connectDB = DBConnection.GetInstall();
                connectDB.GetConnect().Open();
                Console.WriteLine("Connection successfull !");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);

            }

        }

        static void TestGetCustomers()
        {
            CustomerDAO dao = new CustomerDAO();
            ArrayList customers = dao.getCustomers("tranminhtuyen");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }

        }

        static void TestGetListAdmin()
        {
            AdminDAO adminDAO = new AdminDAO();
            ArrayList admins = adminDAO.ListAdmin("nguyenphutai");
            foreach (Admin a in admins)
            {
                Console.WriteLine(a);
            }

        }

        static void TestCheckLogin()
        {
            Admin admin = AdminService.checkLogin("tranminhtuyen", "20130459");
            if (admin == null) { Console.WriteLine("null"); }
            Console.WriteLine(admin);
        }
     
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestGetListAdmin();
            //TestCheckLogin();
            //TestGetCustomers();

            //TestProductDAO.TestInsertProduct();
            //TestProductDAO.TestInsertPriceProduct();
            //TestProductDAO.TestUpdateProduct();
            //TestProductDAO.TestDeleteProduct();
            //TestProductDAO.TestGetIdProduct();
            //TestProductDAO.TestGetListTypeProduct();
            //TestProductDAO.TestGetListStatusProduct();
            //TestProductDAO.TestGetListSupplier();

            //TestProductService.TestAddNewProduct();
            //TestProductService.TestUpdateProduct();
            //TestProductService.TestDeleteProduct();
            //TestProductService.TestGetListTypeStatusSupplier();

            //TestNewsService.TestAddNews();
            ProductDAO ser = new ProductDAO();
            //Console.WriteLine("Hi");
            //Console.WriteLine("Size "+ser.findAll().Count);
               
            Console.Read();
        }
    }
}

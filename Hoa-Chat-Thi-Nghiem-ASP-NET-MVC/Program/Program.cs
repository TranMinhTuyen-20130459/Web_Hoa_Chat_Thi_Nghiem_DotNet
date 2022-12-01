using Model.db;
using Model.dao;
using Model.model;
using System;
using System.Collections;
using Model.service;
using Model.dao;
using Model.entity;
using Model.db;

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

        static void TestGetListAdmin()
        {
            AdminDAO adminDAO = new AdminDAO();
            ArrayList admins = adminDAO.ListAdmin("nguyenphutai");
            foreach(Admin a in admins)
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

        static void TestGetCustomers()
        {
            CustomerDAO dao = new CustomerDAO();
            ArrayList customers= dao.getCustomers("tranminhtuyen");
            foreach(Customer c in customers)
            {
                Console.WriteLine(c);
            }

        }

        static void Main(string[] args)
        {
            //TestGetListAdmin();
            //TestCheckLogin();
            TestGetCustomers();
            Console.Read();
        }
    }
}

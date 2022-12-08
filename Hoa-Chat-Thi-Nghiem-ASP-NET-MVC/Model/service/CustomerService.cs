using Model.dao;
using Model.entity;
using System;
using System.Collections;

namespace Model.service
{
    public class CustomerService
    {
        public static CustomerDAO dao = new CustomerDAO();
        // đăng nhập cho khách hàng
        public static Customer checkLogin(string username, string password)
        {               
            ArrayList listCustomer = dao.getCustomers(username);
            if (listCustomer.Count != 1)
            {
                return null;
            }
            else
            {
                Customer customer = (Customer)listCustomer[0];
                if (customer.Password.Equals(password)) return customer;
            }
            return null;
        }

        public static bool checkExsit(string email)
        {
            return dao.checkExsit(email);
        }

        public static void register(string email, string password)
        {
            dao.register(email, password);
        }
    }
}



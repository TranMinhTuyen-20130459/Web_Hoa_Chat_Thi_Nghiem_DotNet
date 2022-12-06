using Model.dao;
using Model.model;
using System.Collections;

namespace Model.service
{
    public class CustomerService
    {
        // đăng nhập cho khách hàng
        public static Customer checkLogin(string username, string password)
        {
            CustomerDAO dao = new CustomerDAO();
            ArrayList listCustomer = dao.getCustomers(username);
            if (listCustomer.Count > 0)
            {
            }
            else
            {
                Customer customer = (Customer)listCustomer[0];
                if (customer.Password.Equals(password)) return customer;
            }
            return null;
        }
    }
}



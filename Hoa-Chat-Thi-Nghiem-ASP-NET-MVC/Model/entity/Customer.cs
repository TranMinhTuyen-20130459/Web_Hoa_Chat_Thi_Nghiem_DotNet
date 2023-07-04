using System;

namespace Model.entity
{
    public class Customer
    {
        private int id_customer;
        private String username;
        private String password;
        private int id_status_acc;
        private int id_city;
        private String fullname;

        public Customer(int id_customer, string username, string password, int id_status_acc, int id_city, string fullname)
        {
            this.Id_customer = id_customer;
            this.Username = username;
            this.Password = password;
            this.Id_status_acc = id_status_acc;
            this.Id_city = id_city;
            this.Fullname = fullname;
        }

        public int Id_customer { get => id_customer; set => id_customer = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id_status_acc { get => id_status_acc; set => id_status_acc = value; }
        public int Id_city { get => id_city; set => id_city = value; }
        public string Fullname { get => fullname; set => fullname = value; }

        public override string ToString()
        {
            return "Id=" + Id_customer + "User=" + Username + "Pass=" + Password + "Status=" + "City=" + Id_city + "Fullname" + Fullname;
        }
    }
}

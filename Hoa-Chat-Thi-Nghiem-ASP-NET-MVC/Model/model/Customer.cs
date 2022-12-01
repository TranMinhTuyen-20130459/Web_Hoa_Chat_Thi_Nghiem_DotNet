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
        private String sex;
        private String email_customer;
        private String phone_customer;
        private String address;

        public Customer(int id_customer, string username, string password, int id_status_acc, int id_city, string fullname, string sex, string email_customer, string phone_customer, string address)
        {
            this.Id_customer = id_customer;
            this.Username = username;
            this.Password = password;
            this.Id_status_acc = id_status_acc;
            this.Id_city = id_city;
            this.Fullname = fullname;
            this.Sex = sex;
            this.Email_customer = email_customer;
            this.Phone_customer = phone_customer;
            this.Address = address;
        }

        public int Id_customer { get => id_customer; set => id_customer = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id_status_acc { get => id_status_acc; set => id_status_acc = value; }
        public int Id_city { get => id_city; set => id_city = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Email_customer { get => email_customer; set => email_customer = value; }
        public string Phone_customer { get => phone_customer; set => phone_customer = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return "Id=" + Id_customer + "User=" + Username + "Pass=" + Password + "Status=" + "City=" + Id_city + "Fullname" + Fullname +
                "Sex=" + Sex + "Email=" + Email_customer + "Phone" + Phone_customer + "Address=" + Address;
        }
    }
}

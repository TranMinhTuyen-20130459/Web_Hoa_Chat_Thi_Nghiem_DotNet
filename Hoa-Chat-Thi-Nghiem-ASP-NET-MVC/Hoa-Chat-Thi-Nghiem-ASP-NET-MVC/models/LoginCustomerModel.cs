using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models
{
    public class LoginCustomerModel
    {
        private string username;

        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
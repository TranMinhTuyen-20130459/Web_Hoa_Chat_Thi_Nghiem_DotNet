using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models
{
    public class LoginCustomerModel
    {       
        [Required(ErrorMessage = "Vui lòng nhập email!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu!")]
        public string Password { get; set; }
    }
}
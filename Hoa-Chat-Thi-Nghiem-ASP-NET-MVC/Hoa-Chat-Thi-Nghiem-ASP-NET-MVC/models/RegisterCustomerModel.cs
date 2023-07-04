using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models
{
    public class RegisterCustomerModel
    {
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string email { get; set; }
        
        [Required(ErrorMessage = "Vui lòng mật khẩu")]
        public string password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        public string confirm_pass { get; set; }
    }
}
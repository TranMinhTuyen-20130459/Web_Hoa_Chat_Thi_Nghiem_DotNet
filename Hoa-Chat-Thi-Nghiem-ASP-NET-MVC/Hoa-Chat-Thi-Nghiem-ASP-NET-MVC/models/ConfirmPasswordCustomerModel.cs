using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models
{
    public class ConfirmPasswordCustomerModel
    {
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới")]
        public string newPass { get; set; }
        [Required(ErrorMessage = "Vui lòng xác thực mật khẩu mới")]
        public string confirm_newPass { get; set; }
    }
}
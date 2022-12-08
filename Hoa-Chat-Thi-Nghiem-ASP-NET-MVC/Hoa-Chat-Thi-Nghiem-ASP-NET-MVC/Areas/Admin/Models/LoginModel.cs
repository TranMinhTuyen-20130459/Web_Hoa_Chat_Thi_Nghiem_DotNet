using System.ComponentModel.DataAnnotations;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models
{

    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập tên tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string Password { get; set; }

    }
}
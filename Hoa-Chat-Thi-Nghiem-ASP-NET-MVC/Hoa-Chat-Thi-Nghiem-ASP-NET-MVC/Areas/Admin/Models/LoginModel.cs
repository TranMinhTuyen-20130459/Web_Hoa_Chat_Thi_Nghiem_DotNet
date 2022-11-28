using System.ComponentModel.DataAnnotations;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models
{
    
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập tên tài khoản")]
        private string username;

        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        
    }
}
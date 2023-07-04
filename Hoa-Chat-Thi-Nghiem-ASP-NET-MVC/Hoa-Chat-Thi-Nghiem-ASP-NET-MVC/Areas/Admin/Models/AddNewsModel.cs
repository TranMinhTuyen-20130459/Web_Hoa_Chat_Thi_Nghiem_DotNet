using System.ComponentModel.DataAnnotations;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models
{
    public class AddNewsModel
    {
        [Required(ErrorMessage ="Tiêu đề bài viết không được để trống !!!")]
        [MinLength(20,ErrorMessage ="Tiêu đề bài viết không được ít hơn 20 kí tự !!!")]
        public string TitleNews { get; set; }

        [Required(ErrorMessage = "Nội dung bài viết không được để trống")]
        [MinLength(100, ErrorMessage = "Nội dung bài viết không được ít hơn 100 kí tự !!!")]
        public string ContentNews { get; set; }
    }
}
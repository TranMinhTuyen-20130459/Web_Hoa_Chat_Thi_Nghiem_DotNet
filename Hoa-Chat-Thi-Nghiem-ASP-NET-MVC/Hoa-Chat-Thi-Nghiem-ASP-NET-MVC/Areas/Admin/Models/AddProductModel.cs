using System.ComponentModel.DataAnnotations;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models
{
    public class AddProductModel
    {
        [Required(ErrorMessage ="Mời nhập tên sản phẩm")]
        [MinLength(5,ErrorMessage ="Tên sản phẩm phải ít nhất 5 kí tự !!!")]
        public string NameProduct { get; set;}

        [Required(ErrorMessage = "Mời nhập số lượng sản phẩm")]
        [Range(0,10000,ErrorMessage ="Số lượng của sản phẩm phải lớn hơn hoặc bằng 0 và không được vượt quá 10000 sản phẩm")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Mời nhập giá niêm yết của sản phẩm")]
        [Range(0,1000000000,ErrorMessage ="Giá của sản phẩm không được âm và không được vượt quá 1 tỉ đồng ^.^")]
        public int ListedPrice { get; set; }

        [Required(ErrorMessage = "Mời nhập giá bán thực tế của sản phẩm")]
        [Range(0, 1000000000, ErrorMessage = "Giá của sản phẩm không được âm và không được vượt quá 1 tỉ đồng ^.^")]
        public int CurrentPrice { get; set;}

        [Range(1,10000,ErrorMessage ="Hãy chọn loại cho sản phẩm")]
        public int Type { get; set; }

        [Range(1, 10000, ErrorMessage = "Hãy chọn trạng thái cho sản phẩm")]
        public int Status { get; set; }

        [Range(1, 10000, ErrorMessage = "Hãy chọn nhà cung cấp của sản phẩm")]
        public int Supplier { get; set; }

        [Required(ErrorMessage = "Mời nhập mô tả của sản phẩm")]
        [MinLength(255,ErrorMessage ="Mô tả sản phẩm phải ít nhất 255 kí tự !!!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Hãy chọn hình ảnh cho sản phẩm")]
        [RegularExpression("([^\\s]+(\\.(?i)(jpe?g|png|gif|bmp))$)", ErrorMessage ="Đường dẫn của hình ảnh không đúng")]
        public string PathImage { get; set; }
    }
}
using Model.entity;

namespace Model.service
{
    class ProductService
    {

        public static bool addNewProduct(Product p, Admin admin)
        {
            /*
             * B1 : thêm tên,mô tả,hình ảnh,số lượng,mã loại,mã trạng thái,mã nhà cung cấp, tên tài khoản admin vào bảng products
             * B2 : lấy ra id_product dựa vào các thông tin ở B1 trên bảng products
             * B3 : thêm giá niêm yết,giá bán thực tế của sản phẩm dựa trên id_product vào bảng price_product
             */

            return false;
        }

        public static bool updateProduct(Product p, Admin admin)
        {
            return false;
        }

        public static bool deleteProduct(Product p,Admin admin)
        {
            return false;
        }
    }
}

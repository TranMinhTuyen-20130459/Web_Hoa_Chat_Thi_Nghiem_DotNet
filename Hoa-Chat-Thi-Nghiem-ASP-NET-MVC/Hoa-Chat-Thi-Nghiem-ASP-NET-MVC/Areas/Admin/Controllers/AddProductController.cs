using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models;
using Model.service;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Controllers
{
    public class AddProductController : Controller
    {
        // GET: Admin/AddProduct
        public ActionResult Index()
        {
            // lấy ra danh sách các loại sản phẩm , trạng thái sản phẩm , nhà cung cấp cho sản phẩm
            ArrayList listArrayList = ProductService.getListTypeStatusSupplier();
            Session["List-Type-Status-Supplier-Product"] = listArrayList;
            ViewBag.MessAlert = TempData["MessageAlert"];
            return View();
        }

        [HttpPost]
        public ActionResult AddNewProduct(AddProductModel model)
        {
            int TypeProduct = Convert.ToInt32(Request["LoaiSP"]);
            int StatusProduct = Convert.ToInt32(Request["TinhTrangSP"]);
            int Supplier = Convert.ToInt32(Request["NCC"]);
            string PathImage = Request["UrlImage"];
            var regex = new Regex("([^\\s]+(\\.(?i)(jpe?g|png|gif|bmp))$)");

            ViewBag.IdType = TypeProduct;
            ViewBag.IdStatus = StatusProduct;
            ViewBag.IdSupplier = Supplier;
            ViewBag.PathImage = PathImage;

            if (TypeProduct == 0)
            {
                ViewBag.ErrorType = "Hãy chọn loại sản phẩm !!!";
            }
            if (StatusProduct == 0)
            {
                ViewBag.ErrorStatus = "Hãy chọn trạng thái sản phẩm !!!";
            }
            if (Supplier == 0)
            {

                ViewBag.ErrorSupplier = "Hãy chọn nhà cung cấp cho sản phẩm !!!";
            }
            try
            {
                if (!regex.IsMatch(PathImage))
                {
                    ViewBag.ErrorPathImage = "Đường dẫn của hình ảnh không đúng, hãy chọn lại hình ảnh ^.^";
                }
            }
            catch (Exception e)
            {
                ViewBag.ErrorPathImage = "Bạn chưa chọn hình ảnh cho sản phẩm, hãy chọn lại hình ảnh ^.^";
            }

            // tất cả các điều kiện khi kiểm tra bằng tay
            bool conditionValidate = (TypeProduct != 0) && (StatusProduct != 0) && (Supplier != 0)
                                      && (regex.IsMatch(PathImage));

            if (ModelState.IsValid && conditionValidate)
            {
                string name_product = model.NameProduct;
                string desc_product = model.Description;
                int quantity = model.Quantity;
                int listed_price = model.ListedPrice;
                int current_price = model.CurrentPrice;

                var admin = (Model.entity.Admin)Session["ADMIN_SESSION"];
                var product = new Model.entity.Product(name_product, desc_product, PathImage, quantity,
                    TypeProduct, StatusProduct, Supplier, listed_price, current_price);

                bool checkAddNewProduct = ProductService.addNewProduct(product, admin);
                if (checkAddNewProduct)
                {
                    TempData["MessageAlert"] = "Chuc mung ban da them san pham thanh cong ^.^";
                    return RedirectToAction("Index");
                }

            }
            return View("Index");
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models;
using Model.service;
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
            return View();
        }

        [HttpPost]
        public ActionResult AddNewProduct(AddProductModel model)
        {
            if (ModelState.IsValid)
            {
                   
            }
            return View("Index");
        }
    }
}
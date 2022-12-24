using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;
using Model.entity;
using Model.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ListProducts
        public ActionResult ListProducts(int id, int? page)
        {
            ProductsModel model = new ProductsModel();
            return View(model.CreateModel(id, 3, page));
        }
        public ActionResult ProductDetails(int id)
        {
            List<Product> list = ProductService.findOneProductById(id);
            ViewBag.ListProducts = list;
            return View();
        }
        

        [Authorize]
        public ActionResult ShoppingCart()
        {
            return View();
        }
       
    }
}
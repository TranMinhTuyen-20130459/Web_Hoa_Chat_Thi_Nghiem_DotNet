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
        public ActionResult ListProducts(int id)
        {
            List<Product> list = null;
            if (id <= 30)
            {
                list = ProductService.findProductsByIdType(id);
            }
            else // id hoachat =40, id dungcu = 50, id thietbi = 60
            {
                id -= 40;
                list = ProductService.findProductsByIdTypeMain(id);
            }
            ViewBag.ListProducts = list;
            return View();
        }
        public ActionResult ProductDetails(int id)
        {
            List<Product> list = ProductService.findOneProductById(id);
            ViewBag.ListProducts = list;
            return View();
        }
        //[HttpGet]
        //public ActionResult GetData()
        //{
        //    int id = 40;

        //    List<Product> list = null;
        //    if (id <= 30)
        //    {
        //        list = ProductService.findProductsByIdType(id);
        //    }
        //    else // id hoachat =40, id dungcu = 50, id thietbi = 60
        //    {
        //        id -= 40;
        //        list = ProductService.findProductsByIdTypeMain(id);
        //    }
        //    ViewBag.ListProducts = list;
        //    return Json(new { Data = list, TotalItems = list.Count }, JsonRequestBehavior.AllowGet);
        //}


        [Authorize]
        public ActionResult ShoppingCart()
        {
            return View();
        }
       
    }
}
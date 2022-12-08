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
        public ActionResult ListProducts()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }

        [Authorize]
        public ActionResult ShoppingCart()
        {
            return View();
        }
       
    }
}
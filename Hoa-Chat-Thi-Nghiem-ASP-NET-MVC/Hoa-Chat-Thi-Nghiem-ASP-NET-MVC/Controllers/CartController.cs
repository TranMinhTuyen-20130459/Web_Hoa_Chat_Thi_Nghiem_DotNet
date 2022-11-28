using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}
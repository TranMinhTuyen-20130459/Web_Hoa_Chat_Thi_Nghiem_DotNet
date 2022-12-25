using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.entity;
using Org.BouncyCastle.Crypto.Tls;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Checkout()
        {
            if (Session["auth_customer"] == null)
            {
                return RedirectToAction ("Login", "Account");
            }
            if (Session["CartSession"] == null)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Giỏ hàng chưa có sản phẩm'); window.location.href=\"/Home/Index\"</script>");
            }
            Session["TotalPayment"] = 0;
            foreach (var item in (List<CartItem>)Session["CartSession"])
            {
                int total = (int)Session["TotalPayment"];
                total += item.Product.Current_price*item.Quantity;
                Session["TotalPayment"] = total;
            }
            return View();
        }
    }
}
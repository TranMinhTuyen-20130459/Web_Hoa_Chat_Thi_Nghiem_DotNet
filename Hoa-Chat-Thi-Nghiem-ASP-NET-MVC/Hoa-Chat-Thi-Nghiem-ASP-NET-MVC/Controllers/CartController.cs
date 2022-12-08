using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart(int idProduct)
        {
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>) cart;
                //Tìm sản phẩm cần add có trong Cart hay không
                //Nếu có thì tăng Quantity
                foreach (var item in list)
                {
                    if (item.Product.Id_product == idProduct)
                    {
                        item.Quantity++;
                        ViewBag.cartData = cart;
                        return View();
                    }
                }
                //Nếu chưa có thì tạo mới CartItem
                CartItem cartItem = new CartItem();
                list.Add(cartItem);
            }
            else
            {
                //tạo mới Cart Item và Cart
                var item = new CartItem();
                item.Product.Id_product = idProduct;
                item.Quantity = 1;
                var list = new List<CartItem>();
                list.Add(item);

                //Gán Cart vào session
                Session[CartSession] = list;
            }
            ViewBag.cartData = cart;
            return View();
        }

    }
}
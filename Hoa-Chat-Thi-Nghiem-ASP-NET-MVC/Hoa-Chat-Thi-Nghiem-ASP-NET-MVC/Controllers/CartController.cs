using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;
using Model.service;
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
        public ActionResult ShoppingCart()
        {
            return View();
        }
        
        public ActionResult AddItem(int idProduct)
        {
            String s = Request.Path;
            var list = (List<CartItem>)Session[CartSession];
            if (list != null)
            {  
                //Tìm sản phẩm cần add có trong Cart hay không
                //Nếu có thì tăng Quantity
                foreach (var item in list)
                {
                    if (item.Product.Id_product == idProduct)
                    {
                        item.Quantity++;
                        Session[CartSession] = list;
                        return View("ShoppingCart");
                    }
                }
                //Nếu chưa có thì tạo mới CartItem
                CartItem cartItem = new CartItem();
                cartItem.Product = ProductService.findOneProductById(idProduct)[0];
                cartItem.Quantity = 1;
                list.Add(cartItem);
            }
            else
            {
                //tạo mới Cart Item và Cart
                var item = new CartItem();
                item.Product = ProductService.findOneProductById(idProduct)[0];
                item.Quantity = 1;
                list = new List<CartItem>();
                list.Add(item);

                //Gán Cart vào session
                Session[CartSession] = list;
            }
            return View("ShoppingCart");
        }

        public ActionResult RemoveItem(int idProduct)
        {
            var list = (List<CartItem>)Session[CartSession];
            foreach (var item in list)
            {
                if (item.Product.Id_product == idProduct)
                {
                    list.Remove(item);
                    break;
                }
            }
            
            return View();
        }
    }
}
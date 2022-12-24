using Model.entity;
using Model.service;
using System.Collections.Generic;
using System.Web.Mvc;
//using ConnectDB;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> producid17 = ProductService.findOneProductById(17);
            ViewBag.ProductsId17 = producid17;
            List<Product> list = ProductService.findAll();
            ViewBag.ListProducts = list;

            List<TypeProduct> hoachat = ProductService.findTypeProductsById(0);
            List<TypeProduct> dungcu = ProductService.findTypeProductsById(10);
            List<TypeProduct> thietbi = ProductService.findTypeProductsById(20);
            Session["hoachat"] = hoachat;
            Session["dungcu"] = dungcu;
            Session["thietbi"] = thietbi;

            List<Product> dshoachat = ProductService.findProductsByIdTypeMain(0);
            List<Product> dsdungcu = ProductService.findProductsByIdTypeMain(10);
            List<Product> dsthietbi = ProductService.findProductsByIdTypeMain(20);
            ViewBag.Dshoachat = dshoachat;
            ViewBag.Dsdungcu = dsdungcu;
            ViewBag.Dsthietbi = dsthietbi;

            return View();
        }

        
    }
}
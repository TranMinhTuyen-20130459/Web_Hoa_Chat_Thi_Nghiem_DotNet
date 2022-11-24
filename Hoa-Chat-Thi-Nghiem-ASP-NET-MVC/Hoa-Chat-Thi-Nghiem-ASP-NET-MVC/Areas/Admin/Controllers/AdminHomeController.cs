using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        public ActionResult AdminHome()
        {
            return View();
        }

        public ActionResult BillsManager()
        {
            return View();
        }

        public ActionResult ProductsManager()
        {
            return View();
        }

        public ActionResult SalesReport()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }



    }
}
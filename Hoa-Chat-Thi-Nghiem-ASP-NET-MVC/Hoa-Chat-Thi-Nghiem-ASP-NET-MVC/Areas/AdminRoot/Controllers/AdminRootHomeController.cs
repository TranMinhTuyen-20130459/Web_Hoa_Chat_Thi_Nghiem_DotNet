using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.AdminRoot.Controllers
{
    public class AdminRootHomeController : Controller
    {
        // GET: AdminRoot/AdminRootHome
        public ActionResult AdminRootHome()
        {
            return View();
        }

        public ActionResult AdminManager()
        {
            return View();
        }
        public ActionResult CustomerManager()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }

    }
}
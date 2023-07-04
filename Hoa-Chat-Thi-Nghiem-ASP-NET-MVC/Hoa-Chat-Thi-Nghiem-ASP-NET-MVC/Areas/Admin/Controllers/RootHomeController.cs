using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Controllers
{
    public class RootHomeController : Controller
    {
        // GET: Admin/RootHome
        public ActionResult Index()
        {
            return View();
        }
    }
}
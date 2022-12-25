using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.service;
using Model.entity;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult News()
        {

            News news = NewsService.GetNews();
            ViewBag.BaiViet = news;
            return View();
        }
    }
}
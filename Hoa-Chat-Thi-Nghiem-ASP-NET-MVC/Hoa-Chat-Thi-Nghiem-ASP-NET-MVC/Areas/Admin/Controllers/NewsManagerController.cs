using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models;
using Model.entity;
using Model.service;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Controllers
{
    public class NewsManagerController : Controller
    {
        // GET: Admin/NewsManager
        public ActionResult Index()
        {
            ViewBag.MessAlert = TempData["MessageAlert"];
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] // tắt kiểm tra html cho Action AddNews => cụ thể là ckeditor
        public ActionResult AddNews(AddNewsModel model)
        {
            if (ModelState.IsValid)
            {
                News news = new News(model.TitleNews,model.ContentNews);
                var admin = (Model.entity.Admin) Session["ADMIN_SESSION"];

                bool checkAddNews = NewsService.AddNews(news, admin);
                if (checkAddNews)
                {
                    TempData["MessageAlert"] = "Success";
                    return RedirectToAction("Index");
                }         
            }
            return View("Index");
        }
    }
}
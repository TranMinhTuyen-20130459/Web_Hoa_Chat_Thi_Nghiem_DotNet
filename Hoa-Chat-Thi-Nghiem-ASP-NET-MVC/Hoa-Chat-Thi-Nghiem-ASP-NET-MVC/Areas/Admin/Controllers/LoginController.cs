 using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Models;
using Model.service;
using System.Web.Mvc;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var admin = AdminService.checkLogin(model.Username, model.Password);
                if (admin != null)
                {

                    Session["ADMIN_SESSION"] = admin;
                    
                    int role_admin = admin.Id_role_admin;
                    if (role_admin == 1)
                    {
                   
                        return RedirectToAction("Index","RootHome");
                    }
                    else if (role_admin == 2)
                    {
                        return RedirectToAction("Index", "AdminHome");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                }
            }
            return View("Index");
        }

    }
}
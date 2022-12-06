using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;

using Model.service;
using System.Web.Mvc;


namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();

        }
        public ActionResult Logout()
        {
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult loginCustomer(LoginCustomerModel model) {
            if (ModelState.IsValid)
            {
                string username = model.Username;
                string password = model.Password;
                var customer = CustomerService.checkLogin(username, password);
                if (customer != null)
                {
                    Session["auth_customer"] = customer;
                    return RedirectToAction("Index", "Controllers");
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
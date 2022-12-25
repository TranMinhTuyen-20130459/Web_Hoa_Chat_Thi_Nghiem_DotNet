using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;

using Model.service;
using System.Web.Mvc;
using System.Web.Security;
using System;
using System.Web.Helpers;
using Model.entity;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("auth_customer");
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult forgotPasswordCustomer(ForgotPassCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                string email = model.email;
                if (!CustomerService.checkExsit(email))
                {
                    Session["email"] = email;
                    return RedirectToAction("ConfirmPassword", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại trong hệ thống");
                }
            }
            return View("ForgotPassword");
        }
        //Xác thực mật khẩu
        [HttpGet]
        public ActionResult ConfirmPassword()
        {
            if (Session["email"] == null)
            {
                return RedirectToAction("ForgotPassword", "Account");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult confirmPasswordCustomer(ConfirmPasswordCustomerModel model)
        {
                if (ModelState.IsValid)
                {
                    
                    string newPass = model.newPass;
                    string confirm_newPass = model.confirm_newPass;
                    if (newPass.Equals(confirm_newPass))
                    {
                    string email = (string)(Session["email"]);
                        CustomerService.changePass(email, newPass);
                        ViewBag.success_newPass = "Đổi mật khẩu thành công";
                        Session.Remove("email");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Hãy xác thực lại mật khẩu");
                    }
                }
                return View("ConfirmPassword");
        }

        //Đổi mật khẩu
        [Authorize]
        [HttpGet]       
        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult changePasswordAccount(ChangePassCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = Session["auth_customer"];
                if (customer != null)
                {
                    string oldPass = ((Customer)customer).Password;
                    string email = ((Customer)customer).Username;
                    string confirm_old = model.oldPass;
                    string newPass = model.newPass;
                    string confirm_new = model.newPass;
                    if (oldPass.Equals(confirm_old))
                    {
                        if (newPass.Equals(confirm_new))
                        {
                            CustomerService.changePass(email, newPass);
                            ViewBag.success_newPass = "Đổi mật khẩu thành công";
                        }
                        else
                        {
                            ModelState.AddModelError("", "Xác thực mật khẩu mới không hợp lệ");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Xác thực lại mật khẩu cũ");
                    }
                }
            }
            return View("ChangePassword");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult registerCustomer(RegisterCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                string email = model.email;
                string password = model.password;
                string confirm_pass = model.confirm_pass;
                if (CustomerService.checkExsit(email))
                {
                    if (password.Equals(confirm_pass))
                    {
                        CustomerService.register(email,password);
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Xác thực mật khẩu không hợp lệ");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản đã tồn tại");
                }
            }
            return View("Register");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult loginCustomer(LoginCustomerModel model) {
            if (ModelState.IsValid)
            {
                string username = model.Username;
                string password = model.Password;
                var customer = CustomerService.checkLogin(username, password);
                if (customer != null)
                {
                    FormsAuthentication.SetAuthCookie(customer.Username, false);
                    Session["auth_customer"] = customer;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                }
            }
            return View("Login");
        }
    }
}
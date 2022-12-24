using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;

using Model.service;
using System.Web.Mvc;
using System.Web.Security;
using System;
using System.Web.Helpers;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        string emailForForgotPass = null;
        // GET: Account
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
                    emailForForgotPass = email;
                    Session["email"] = emailForForgotPass;
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
                return View("ForgotPassword");
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
                        CustomerService.changePass(emailForForgotPass, newPass);
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
                        ModelState.AddModelError("", "Đăng ký thành công");
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
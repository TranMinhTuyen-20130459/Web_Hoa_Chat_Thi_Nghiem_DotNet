﻿using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;

using Model.service;
using System.Web.Mvc;
using System.Web.Security;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("auth_customer");
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [Authorize]
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
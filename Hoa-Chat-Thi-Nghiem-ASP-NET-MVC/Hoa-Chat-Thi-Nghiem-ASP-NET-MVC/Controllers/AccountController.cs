using Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Models;
using Model.entity;
using Model.service;
using System.Web.Mvc;
using System.Web.Security;
using System;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        public string emailForForgotPass;
        // GET: Account
        //Đăng xuất
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("auth_customer");
            return RedirectToAction("Index", "Home");
        }

        //Quên mật khẩu
        //nhập Email
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
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult changePasswordCustomer(ChangePassCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                string oldPass = model.oldPass;
                string newPass = model.newPass;
                string confirm_newPass = model.confirm_newPass;
                Customer customer = (Customer)Session["auth_customer"];
                if ((customer.Password).Equals(oldPass))
                {
                    if (newPass.Equals(confirm_newPass))
                    {
                        CustomerService.changePass(customer.Username, newPass);
                        ViewBag.success_changePass = "Đổi mật khẩu thành công";
                        //ModelState.AddModelError("success", "đổi mật khẩu thành công");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Xác thực mật khẩu không đúng");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu cũ không đúng");
                }
            }
            return View("ChangePassword");
        }

//Đăng ký
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
                        ViewBag.success_registier = "Đăng ký thành công";
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

//Đăng nhập
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
                    if(customer.Id_status_acc == 2)
                    {
                        ViewBag.ban = "Tài khoản đã bị tạm khóa";
                    }else if(customer.Id_status_acc == 3)
                    {
                        ViewBag.ban = "Tài khoản đã bị khóa vĩnh viễn";
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(customer.Username, false);
                        Session["auth_customer"] = customer;
                        return RedirectToAction("Index", "Home");
                    }
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
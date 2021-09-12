using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult announce(string thongBao)
        {
            ViewBag.thongBao = thongBao;
            return View();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Loggin(string password, string Username)
        {
            // kiểm tra tên đăng nhập và mật khẩu
            // Username:ngokimhuy password: 123456
            if (Username == "ngokimhuy" && password == "123456")
            {
                // chuyển hướng sang quanlytaikhoan
                return Redirect("/danhMuc/QuanLyTaiKhoan");
            }
            return View();
        }
        public ActionResult Loggin(string password, string Usernam)
        {
            if(Username == "huymapdit" && password == 12333)
            {
                return Redirect("/danhMuc/QuanLyTaiKhoan")
            }
        }
 }
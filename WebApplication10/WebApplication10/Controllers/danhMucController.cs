using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication10.Controllers
{
    public class danhMucController : Controller
    {
        // GET: danhMuc
        public ActionResult QuanLyTaiKhoan(string thongBao)
        {
            ViewBag.thongBao = thongBao;
            return View();
        }
        public ActionResult ChiTietBoCuc()
        {
            return View();
        }
        public ActionResult training()
        {
            return View();
        }
        public ActionResult trainer()
        {
            return View();
        }
    }
}
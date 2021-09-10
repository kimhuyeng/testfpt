using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class LoginPageController : Controller
    {
        // GET: LoginPage
        public ActionResult DangNhap()
        {
            return View();
        }
    }
}
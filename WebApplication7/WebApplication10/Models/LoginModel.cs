using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class LoginModel
    {
        [Display( Name ="Tên đăng nhập")]
        [Required(ErrorMessage =" Yêu cầu bạn phải nhập tài khoản ")]
        public string Username { set; get; }

        [Display( Name=" Mật khẩu")]
        [Required(ErrorMessage =" Yêu cầu bạn phải nhập mật khẩu ")]
        public string Password { set; get; }
    }
}
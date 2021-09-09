using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Login
    {
        [Display(Name ="Ten dang nhap")]
        [Required(ErrorMessage = " yeu cau ban dang nhap tai khona")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " yeu cau ban nhap mat khau")]
        [Display(Name = " Mat khau ")]
        public string PassWord { get; set; }
    }
}
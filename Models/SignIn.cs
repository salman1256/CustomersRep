using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class SignIn
    {    [Display(Name ="User Name")]
         [DataType(DataType.Text)]
         [Required]
        public string UserName { get; set; }
        [Display(Name = "User Password")]
        [DataType(DataType.Password)]
        [Required]
        public string  UserPwd { get; set; }
    }
}
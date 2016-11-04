using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using modusChatter.Controllers;
using modusChatter.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;

namespace modusChatter.Models
{
    public class Register
    {
        [Key]

        [Required(ErrorMessage ="Please enter name",AllowEmptyStrings =false)]
        public string fullname { get; set; }

       [Required(ErrorMessage ="Please enter password")]
       [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please enter username")]
        public string userName { get; set; }

        [Required(ErrorMessage ="please enter  the programme Field ")]
        public string programmeTitle { get; set; }
        
        [Compare("Password",ErrorMessage = "The password must match")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage ="Please enter valid email address")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="Enter valid email address")]
        public string email { get; set; }
    }
}
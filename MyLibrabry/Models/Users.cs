using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyLibrabry.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Please Enter Your National Id")]
        [Display(Name = "National Id")]
        public int u_id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string u_fname { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string u_lname { get; set; }
        public string hdate { get; set; }
        public int salary { get; set; }
        [Range(18, 45, ErrorMessage = "Please Enter Age Between 18 and 45")]
        public int age { get; set; }
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string u_address { get; set; }
        public int phone { get; set; }
        public string u_name { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string u_password { get; set; }
        [Compare("u_password", ErrorMessage = "Password And Confirm Password don't Match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string Confpwd { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Please Enter valid Email Address")]
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public string u_email { get; set; }
        public string photo { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1DA.ViewModels
{
    public class Login
    {
        [Display(Name="Email ID")]
        [EmailAddress(ErrorMessage ="Please enter a valid Email Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "EmailID is not valid")] 
        [Required(ErrorMessage ="Email ID is required")]
        public string EmailID { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{10,}", ErrorMessage = "Your password must be at least 5 characters long and contain at least 1 UpperCase, 1 " +
            "LowerCase and 1 number")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}

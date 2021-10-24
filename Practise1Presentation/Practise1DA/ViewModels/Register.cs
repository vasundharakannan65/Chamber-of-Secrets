using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practise1DA.ViewModels
{
    public class Register
    {
        [Display(Name = "EmailID")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "EmailID is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "EmailID is not valid")]
        [EmailAddress(ErrorMessage = "Please enter valid EmailID")]
        public string EmailId { get; set; }

        [RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{10,}", ErrorMessage = "Your password must be at least 5 characters long and contain at least 1 UpperCase, 1 " +
            "LowerCase and 1 number")]
        [Required(ErrorMessage = "The Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Confirm Password is required")]
        [Compare("Password",ErrorMessage = "Confirm Password doesn't match with Password")]
        public string ConfirmPassword { get; set; }


        public bool Administrator { get; set; }
    }
}

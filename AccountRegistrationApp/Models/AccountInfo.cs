using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountRegistrationApp.Models
{
    public class AccountInfo
    {
        [Required]
        [Display(Name = "User ID")]
        public string Userid { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MaxLength(8, ErrorMessage = "{0} can allow a max of {1} characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [MaxLength(8, ErrorMessage = "{0} can allow a max of {1} characters")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
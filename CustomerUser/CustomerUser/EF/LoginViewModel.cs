using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerUser.EF
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]*[@][a-zA-Z]*[.][c][o][m]", ErrorMessage = "Invalid Email!")]

        public string Email { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Password must be 4 or more characters")]

        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}
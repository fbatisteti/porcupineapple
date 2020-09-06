using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PorcupineApple.Shared
{
    public class User
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DOB { get; set; }

        [Required (ErrorMessage = "Please insert a valid e-mail")]
        // requires e-mail to be "SOMETHING + @SOMETHING + .SOMETHING + SOMETHING"
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please inform a valid e-mail")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Password must contain at least 6 characters")]
        // requires a minimum of 6 characters in password, up to a maximum of an absurdly high number
        [StringLength(255, MinimumLength = 6)]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PorcupineApple.Shared
{
    public class Genre
    {
        public int Id { get; set; }

        //[Required (ErrorMessage = "message")]
        [Required]
        public string Name { get; set; }
    }
}

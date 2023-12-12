using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required, StringLength(50, ErrorMessage = "Email maksimum 50 karakter olabilir.")]
        public string  Email { get; set; }
        [Required, StringLength(50, ErrorMessage = "Şifre maksimum 50 karakter olabilir.")]
        public string Password { get; set; }

        public string Authority { get; set; }
    }
}
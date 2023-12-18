using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(150, ErrorMessage = "Adres maksimum 500 0karakter olabilir.")]
        public string Address { get; set; }
        [StringLength(150, ErrorMessage = "Telefon numarası maksimum 50 karakter olabilir.")]
        public string TelNumber { get; set; }
        [StringLength(150, ErrorMessage = "Fax maksimum 50 karakter olabilir.")]
        public string Fax { get; set; }
        [StringLength(150, ErrorMessage = "Whatsapp maksimum 50 karakter olabilir.")]
        public string Whatsapp { get; set; }
        [StringLength(150, ErrorMessage = "Facebook maksimum 50 karakter olabilir.")]
        public string Facebook { get; set; }
        [StringLength(150, ErrorMessage = "Instagram maksimum 50 karakter olabilir.")]
        public string Instagram { get; set; }
        [StringLength(150, ErrorMessage = "Twitter maksimum 50 karakter olabilir.")]
        public string Twitter { get; set; }
    }
}
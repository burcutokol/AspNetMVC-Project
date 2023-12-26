using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Model
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required, StringLength(150, ErrorMessage = "Servis ismi maksimum 500 karakter olabilir.")]
        [DisplayName("Servis İsmi")]
        public string ServiceTitle { get; set; }
        [DisplayName("Servis Açıklaması")]
        public string ServiceDescription { get; set; }
        [DisplayName("Servis Resim")]
        public string ImageURL { get; set; }
    }
}
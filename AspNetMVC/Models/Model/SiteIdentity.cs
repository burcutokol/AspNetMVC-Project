using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Model
{
    [Table("SiteIdentity")]
    public class SiteIdentity
    {
        [Key]
        public int SiteId { get; set; }
        [DisplayName("Site Baslık")]
        [Required, StringLength(150, ErrorMessage = "Başlık maksimum 150 karakter olabilir.")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(250, ErrorMessage = "Anahtar Kelimeler maksimum 250 karakter olabilir.")]
        public string Keywords { get; set; }
        [DisplayName("Açıklama")]
        [Required, StringLength(500, ErrorMessage = "Açıklama maksimum 500 karakter olabilir.")]
        public string Description { get; set; }
        [DisplayName("Site Logo")]
        public string LogoURL { get; set; }
        [DisplayName("Site Unvan")]
        public string Alias { get; set; }
    }
}
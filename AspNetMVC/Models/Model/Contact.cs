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

        public string Address { get; set; }

        public string TelNumber { get; set; }

        public string Fax { get; set; }

        public string Whatsapp { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
    }
}
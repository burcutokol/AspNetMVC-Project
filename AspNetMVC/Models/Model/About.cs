﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Model
{
    [Table("About")]
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [DisplayName("Hakkımızda Açıklama")]
        public string Description { get; set; }
    }
}
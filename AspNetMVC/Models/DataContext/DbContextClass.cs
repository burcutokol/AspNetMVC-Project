using AspNetMVC.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.DataContext
{
    public class DbContextClass : DbContext
    {
        public DbContextClass() : base("KurumsalDB") //web configde bulunan connection stringde bulunan isimle eşleşmeli
        {

        }
        public DbSet<About> About { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Service> Service { get; set; }  
        public DbSet<SiteIdentity> SiteIdentity { get; set; }
    }
}
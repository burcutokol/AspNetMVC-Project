using AspNetMVC.Models;
using AspNetMVC.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class AdminController : Controller
    {
        DbContextClass db = new DbContextClass();
        public ActionResult Index()
        {
           var sql = db.Category.ToList();
            return View(sql);
        }
    }
}
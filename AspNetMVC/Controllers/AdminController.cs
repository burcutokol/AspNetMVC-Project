using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class AdminController : Controller
    {
        KurumsalDb kurumsalDb = new KurumsalDb();
        // GET: Admin
        public ActionResult Index()
        {
            var sql = kurumsalDb.Categories.ToList();
            return View(sql);
        }
    }
}
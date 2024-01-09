using AspNetMVC.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class IdentityController : Controller
    {
        DbContextClass db = new DbContextClass();
        // GET: Identity
        public ActionResult Index()
        {
            return View(db.SiteIdentity.ToList());
        }

    
        // GET: Identity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Identity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using Lr1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lr1.Filters;

namespace Lr1.Controllers
{
    [Culture]
    public class AddDTPController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: AddDTP
        [HttpGet]
        public ActionResult Create()
        {
            IEnumerable<DTP> dtps = context.Dtps;

            ViewBag.Dtps = dtps;
            return View();
        }
        [HttpPost]
        public ActionResult Create(DTP dtp)
        {
            IEnumerable<DTP> dtps = context.Dtps;

            ViewBag.Dtps = dtps;
            context.Dtps.Add(dtp);
            context.SaveChanges();

            return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult EditDTP(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            DTP dtp = context.Dtps.Find(id);
            if (dtp != null)
            {
                return View(dtp);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditDTP(DTP dtp)
        {
            context.Entry(dtp).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            IEnumerable<DTP> dtps = context.Dtps;

            ViewBag.Dtps = dtps;
            DTP dtp = context.Dtps.Find(id);
            if (dtp != null)
            {
                context.Dtps.Remove(dtp);
                context.SaveChanges();
            }
            return RedirectToAction("Create");
        }
    }
}
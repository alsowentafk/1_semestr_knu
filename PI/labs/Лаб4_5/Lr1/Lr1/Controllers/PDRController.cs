using Lr1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lr1.Controllers
{
    public class PDRController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            IEnumerable<PDR> pdrs = db.Pdrs;

            ViewBag.Pdrs = pdrs;
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(PDR pdr)
        {
            if (!ModelState.IsValid)
            {
                Response.Write("<script>window.alert('Заповніть всі поля!');</script>");
                return View();
            }
            else
            {
                db.Pdrs.Add(pdr);
                db.SaveChanges();
                return RedirectToAction("../home/");
            }
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            PDR pdr = db.Pdrs.Find(id);
            if (pdr != null)
            {
                return View(pdr);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(PDR pdr, int[] selectedShtrafs)
        {
            PDR newPdr = db.Pdrs.Find(pdr.Id);
            newPdr.Name = pdr.Name;
            db.Entry(newPdr).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            PDR b = db.Pdrs.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PDR s = db.Pdrs.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            db.Pdrs.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
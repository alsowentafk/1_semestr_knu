using Lr1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lr1.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ActionResult Index()
        {
            IEnumerable<DTP> dtps = context.Dtps;

            ViewBag.Dtps = dtps;

            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(DTP dtp)
        {
            if (!ModelState.IsValid)
            {
                Response.Write("<script>window.alert('Заповніть всі поля!');</script>");
                return View();
            }
            else
            {
                context.Dtps.Add(dtp);
                context.SaveChanges();
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
            DTP dtp = context.Dtps.Find(id);
            ViewBag.Pdrs = context.Pdrs.ToList();
            if (dtp != null)
            {
                return View(dtp);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(DTP dtp, int[] selectedPDRs)
        {
            DTP newDTP = context.Dtps.Find(dtp.Id);
            newDTP.Name = dtp.Name;
            newDTP.Type = dtp.Type;
            newDTP.Price = dtp.Price;
            newDTP.Pdrs.Clear();
            if (selectedPDRs!= null)
            {
                foreach (var c in context.Pdrs.Where(co =>
               selectedPDRs.Contains(co.Id)))
                {
                    newDTP.Pdrs.Add(c);
                }
            }
            context.Entry(newDTP).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            DTP b = context.Dtps.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DTP b = context.Dtps.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            context.Dtps.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
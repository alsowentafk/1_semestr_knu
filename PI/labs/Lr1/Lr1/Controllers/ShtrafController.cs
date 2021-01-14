using Lr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lr1.Controllers
{
    public class ShtrafController : Controller
    {
        // GET: Shtraf
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Buy
        [HttpGet]
        public ActionResult Shtraf(int id)
        {
            ViewBag.ProductId = id;

            DTP dtp = context.Dtps.Find(id);
            if (dtp != null)
            {
                return View(dtp);
            }
            return View("Buy");
        }
        [HttpPost]
        public string Shtraf(Shtraf shtraf)
        {
            shtraf.Date = DateTime.Now;

            context.Shtrafs.Add(shtraf);

            context.SaveChanges();
            return "Штраф персоны" + shtraf.Person + ",зарегестрировано!";
        }
    }

}

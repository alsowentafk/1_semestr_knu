using Laba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laba1.Controllers
{
    public class BuyController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Buy
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ProductId = id;

            Phone phone = context.Phones.Find(id);
            if (phone != null)
            {
                return View(phone);
            }
            return View("Buy");
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            context.Purchases.Add(purchase);

            context.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    }
}
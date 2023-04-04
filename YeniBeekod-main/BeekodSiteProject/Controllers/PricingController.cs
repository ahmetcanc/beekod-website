using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class PricingController : Controller
    {
        Context c = new Context();
        // GET: Pricing
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Pricings.ToList());
        }
        [HttpGet]
        public ActionResult İcerikEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İcerikEkle(Pricing p)
        {
            c.Pricings.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index", "Pricing");
        }
        public ActionResult İcerikSil(int id)
        {
            var bul = c.Pricings.Find(id);
            c.Pricings.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Index", "Pricing");
        }
        [HttpGet]
        public ActionResult İcerikGuncelle(int id)
        {
            var bul = c.Pricings.Find(id);
            return View(bul);
        }
        [HttpPost]
        public ActionResult İcerikGuncelle(Pricing p)
        {
            var data = c.Pricings.Where(x => x.Id == p.Id).SingleOrDefault();
            data.Title = p.Title;
            data.Price = p.Price;
            data.Ozellik1 = p.Ozellik1;
            data.Ozellik2 = p.Ozellik2;
            data.Ozellik3 = p.Ozellik3;
            data.Ozellik4 = p.Ozellik4;
            data.Ozellik5 = p.Ozellik5;
            data.Ozellik6 = p.Ozellik6;
            c.SaveChanges();
            return RedirectToAction("Index", "Pricing");
        }
    }
}
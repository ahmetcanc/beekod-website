using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Homes.ToList());
        }
        [HttpGet]
        public ActionResult İcerikEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İcerikEkle(Home h)
        {
            c.Homes.Add(h);
            c.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult İcerikSil(int id)
        {
            var bul = c.Homes.Find(id);
            c.Homes.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult İcerikGuncelle(int id)
        {
            var bul = c.Homes.Find(id);
            return View(bul);
        }
        [HttpPost]
        public ActionResult İcerikGuncelle(Home p)
        {
            var data = c.Homes.Where(x => x.SliderId == p.SliderId).SingleOrDefault();
            data.Title = p.Title;
            data.Content = p.Content;
            data.ImageUrl = p.ImageUrl;
            data.Url = p.Url;
            c.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
       
    }
}
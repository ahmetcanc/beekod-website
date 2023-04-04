using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        // GET: About
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Abouts.ToList());
        }
        [HttpGet]
        public ActionResult IcerikEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IcerikEkle(About a)
        {
            c.Abouts.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index", "About");
        }
        public ActionResult IcerikSil(int id)
        {
            var bul = c.Abouts.Find(id);
            c.Abouts.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public ActionResult IcerikGuncelle(int id)
        {
            var bul = c.Abouts.Find(id);
            return View(bul);
        }
        [HttpPost]
        public ActionResult IcerikGuncelle(About p)
        {
            var data = c.Abouts.Where(x => x.Id == p.Id).SingleOrDefault();
            data.Title = p.Title;
            data.PhotoUrl = p.PhotoUrl;
            data.Content = p.Content;
            c.SaveChanges();
            return RedirectToAction("Index", "About");
        }
    }
}
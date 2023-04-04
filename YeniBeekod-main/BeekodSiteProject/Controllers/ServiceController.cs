using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class ServiceController : Controller
    {
        Context c = new Context();
        // GET: Service
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Services.ToList());
        }
        [HttpGet]
        public ActionResult İcerikEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İcerikEkle(Service s)
        {
            c.Services.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index", "Pricing");
        }
    }
}
using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        // GET: Contact
        [Authorize]
        public ActionResult Index()
        {
            return View(c.Contacts.ToList());
        }
        [HttpGet]
        public ActionResult İcerikEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İcerikEkle(Contact co)
        {
            c.Contacts.Add(co);
            c.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
        public ActionResult İcerikSil(int id)
        {
            var bul = c.Contacts.Find(id);
            c.Contacts.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
        public ActionResult İcerikGuncelle(int id)
        {
            var bul = c.Contacts.Find(id);
            return View(bul);
        }
        [HttpPost]
        public ActionResult İcerikGuncelle(Contact co)
        {
            var data = c.Contacts.Where(x => x.Id == co.Id).SingleOrDefault();
            data.NameSurname = co.NameSurname;
            data.EMail = co.EMail;
            data.Subject = co.Subject;
            data.Message = co.Message;
            c.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}
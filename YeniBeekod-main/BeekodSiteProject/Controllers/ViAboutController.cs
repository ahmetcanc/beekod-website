using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class ViAboutController : Controller
    {
        Context c = new Context();
        // GET: ViAbout

        public ActionResult Index()
        {
            return View(c.Abouts.ToList());
        }
    }
}
using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class FeauturesController : Controller
    {
        Context c = new Context();
        // GET: Feautures
        public ActionResult Index()
        {
            return View(c.Feautures.ToList());
        }
    }
}
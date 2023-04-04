using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class ViServiceController : Controller
    {
        // GET: ViService
        Context c = new Context();
        public ActionResult Index()
        {
            return View(c.Services.ToList());
        }
    }
}
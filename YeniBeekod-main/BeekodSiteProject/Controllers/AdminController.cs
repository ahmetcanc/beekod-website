using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BeekodSiteProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            var login = c.Admins.FirstOrDefault(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == admin.Sifre);

            if (login != null)
            {
                Session["adminid"] = login.Id;
                FormsAuthentication.SetAuthCookie(login.KullaniciAdi, false);
                Session["KullaniciAdi"] = login.KullaniciAdi;
                return RedirectToAction("Index", "Home");
            }

            else
            {
                return RedirectToAction("Index", "Admin");
            }

        }
    }
}

//var login = c.Admins.Where(x => x.Id != 0).SingleOrDefault();
//if (login.Id != 0)
//{
//    if (login.KullaniciAdi == admin.KullaniciAdi && login.Sifre == admin.Sifre)
//    {
//        Session["Id"] = login.Id;
//        Session["kullaniciadi"] = login.KullaniciAdi;
//        TempData["success"] = "Giriş başarıyla gerçekleşti";
//        RedirectToAction("Index", "Home");

//    }
//    else
//        RedirectToAction("Index", "Admin");


//}

//else
//    RedirectToAction("Index", "Admin");

//return RedirectToAction("Index", "Admin");
using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BeekodSiteProject.Controllers
{
    public class ViContactController : Controller
    {
        // GET: ViContact
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("denemebeekod@gmail.com");
            mailim.From = new MailAddress(model.Emails);
            mailim.Subject = "Bize ulaşın sayfasından mesajınız var. " + model.Konu;
            mailim.Body = "Sayın Yetkili," + model.Adsoyad + "Kişisinden Gelen Mesaj Aşağıdaki Gibidir. </br>" + model.Mesaj;
            mailim.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("denemebeekod@gmail.com", "stqcjmrxdhbiuplf");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mailim);
                TempData["Message"] = "Mesajınız iletilmiştir. En kısa zamanda size geri dönüş sağlanacaktır.";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Mesaj gönderilemedi. En kısa zamanda size geri dönüş sağlanacaktır." + ex.Message;
            }
            return View();
        }
    }
}
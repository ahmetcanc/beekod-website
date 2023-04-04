using BeekodSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BeekodSiteProject.Controllers
{

    public class ViPricingController : Controller
    {
        // GET: ViPricing
        Context c = new Context();
        public ActionResult Index()
        {
            return View(c.Pricings.ToList());
        }
        [HttpPost]
        public ActionResult Index(Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("denemebeekod@gmail.com");
            mailim.From = new MailAddress(model.Emails);
            mailim.Subject = "Bu mesaj fiyatlandırma ekranından gelmiştir. " + model.Konu;
            mailim.Body = "Sayın Yetkili," + model.Adsoyad + "Kişisinden Gelen Telefon Numarası Aşağıdaki Gibidir. </br>" + model.Mesaj;
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
            return RedirectToAction("Index","ViPricing");
        }

        [HttpPost]
        public ActionResult getTable(int id)
        {
            var list = c.InfoBars.Where(x=>x.Id==id).ToList();


            return PartialView("~/Views/_partials/_pricing.cshtml", list);


        }
    }
}
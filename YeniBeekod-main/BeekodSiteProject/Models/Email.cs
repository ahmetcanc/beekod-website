using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeekodSiteProject.Models
{
    public class Email
    {
        [Key]
        public string Adsoyad { get; set; }
       
        public string Emails { get; set; }
        
        public string Konu { get; set; }
        
        public string Mesaj { get; set; }
    }
}
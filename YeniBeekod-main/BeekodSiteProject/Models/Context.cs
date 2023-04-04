using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BeekodSiteProject.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=BeeKodSite")
        {
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<FeatureBeeKod> FeatureBeeKods { get; set; }
        public virtual DbSet<Feauture> Feautures { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<InfoBar> InfoBars { get; set; }
        public virtual DbSet<Pricing> Pricings { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<BeekodSiteProject.Models.Email> Emails { get; set; }
    }
}

namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoBar")]
    public partial class InfoBar
    {
        [Key]
        public int Id { get; set; }
        public string TFeature1 { get; set; }
        public string TFeature2 { get; set; }
        public string TFeature3 { get; set; }
        public string TFeature4 { get; set; }
        public string TFeature5 { get; set; }
        public string TFeature6 { get; set; }
        public string TFeature7 { get; set; }
        public string TFeature8 { get; set; }
        public string TFeature9 { get; set; }
        public string TFeature10 { get; set; }
    }
}

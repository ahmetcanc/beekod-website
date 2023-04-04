namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ServTitle { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string ServDes { get; set; }
    }
}

namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Home")]
    public partial class Home
    {
        [Key]
        public int SliderId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string Url { get; set; }

        [Required]
        [StringLength(50)]
        public string ImageUrl { get; set; }
    }
}

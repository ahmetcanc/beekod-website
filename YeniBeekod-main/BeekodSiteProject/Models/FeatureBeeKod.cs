namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeatureBeeKod")]
    public partial class FeatureBeeKod
    {
        [Key]
        public int FeauturesId { get; set; }

        [Required]
        [StringLength(200)]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string İconUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
    }
}

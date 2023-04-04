namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feauture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FeauturesId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string VideoUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string IconUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string FeaTitle { get; set; }

        [Required]
        [StringLength(500)]
        public string FeaContent { get; set; }
    }
}

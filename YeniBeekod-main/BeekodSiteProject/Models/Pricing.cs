namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pricing")]
    public partial class Pricing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Price { get; set; }
        
        [StringLength(50)]
        public string Ozellik1 { get; set; }
        
        [StringLength(50)]
        public string Ozellik2 { get; set; }
      
        [StringLength(50)]
        public string Ozellik3 { get; set; }
       
        [StringLength(50)]
        public string Ozellik4 { get; set; }
      
        [StringLength(50)]
        public string Ozellik5 { get; set; }
      
        [StringLength(50)]
        public string Ozellik6 { get; set; }

    }
}

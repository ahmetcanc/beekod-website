namespace BeekodSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NameSurname { get; set; }

        [Required]
        [StringLength(100)]
        public string EMail { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }


        [Required]
        [StringLength(250)]
        public string Message { get; set; }
    }
}

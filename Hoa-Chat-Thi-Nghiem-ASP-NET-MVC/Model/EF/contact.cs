namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contact")]
    public partial class contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_contact { get; set; }

        [Required]
        [StringLength(50)]
        public string full_name { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_contact { get; set; }

        [Required]
        [StringLength(50)]
        public string email_contact { get; set; }

        [Required]
        [StringLength(255)]
        public string problem_name { get; set; }

        [Required]
        public string content_problem { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_insert { get; set; }
    }
}

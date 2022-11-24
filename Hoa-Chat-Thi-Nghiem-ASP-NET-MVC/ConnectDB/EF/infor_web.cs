namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class infor_web
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_infor { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_web { get; set; }

        [Required]
        [StringLength(100)]
        public string email_web { get; set; }

        [Required]
        [StringLength(100)]
        public string address_web { get; set; }
    }
}

namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class account_admin
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        public int id_role_admin { get; set; }

        public int id_status_acc { get; set; }

        [Required]
        [StringLength(50)]
        public string passwordAD { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_change_pass { get; set; }

        public virtual status_acc status_acc { get; set; }

        public virtual role_admin role_admin { get; set; }
    }
}

namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class account_customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public account_customer()
        {
            bills = new HashSet<bill>();
            comment_news = new HashSet<comment_news>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user_customer { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string pass { get; set; }

        public int id_status_acc { get; set; }

        public int id_city { get; set; }

        [StringLength(255)]
        public string fullname { get; set; }

        [StringLength(50)]
        public string sex { get; set; }

        [StringLength(50)]
        public string email_customer { get; set; }

        [StringLength(15)]
        public string phone_customer { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_change_pass { get; set; }

        public virtual status_acc status_acc { get; set; }

        public virtual city city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill> bills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment_news> comment_news { get; set; }
    }
}

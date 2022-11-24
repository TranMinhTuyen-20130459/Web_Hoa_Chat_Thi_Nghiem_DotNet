namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bill()
        {
            bill_detail = new HashSet<bill_detail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bill { get; set; }

        public int id_user { get; set; }

        public int id_status_bill { get; set; }

        public int id_city { get; set; }

        [Required]
        [StringLength(100)]
        public string fullname_customer { get; set; }

        [Required]
        [StringLength(20)]
        public string phone_customer { get; set; }

        [Required]
        [StringLength(50)]
        public string email_customer { get; set; }

        [Required]
        [StringLength(255)]
        public string address_customer { get; set; }

        public long bill_price { get; set; }

        public long total_price { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_order { get; set; }

        public virtual account_customer account_customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_detail> bill_detail { get; set; }

        public virtual status_bill status_bill { get; set; }

        public virtual city city { get; set; }
    }
}

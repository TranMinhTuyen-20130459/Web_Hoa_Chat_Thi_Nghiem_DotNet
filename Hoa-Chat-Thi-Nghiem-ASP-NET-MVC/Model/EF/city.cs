namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("city")]
    public partial class city
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city()
        {
            account_customer = new HashSet<account_customer>();
            bills = new HashSet<bill>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_city { get; set; }

        [Required]
        [StringLength(100)]
        public string name_city { get; set; }

        public long transport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<account_customer> account_customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill> bills { get; set; }
    }
}

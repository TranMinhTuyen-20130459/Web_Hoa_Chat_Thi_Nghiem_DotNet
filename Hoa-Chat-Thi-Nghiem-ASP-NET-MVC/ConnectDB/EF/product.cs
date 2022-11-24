namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            bill_detail = new HashSet<bill_detail>();
            price_product = new HashSet<price_product>();
            sold_product = new HashSet<sold_product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_product { get; set; }

        public int id_type_product { get; set; }

        public int id_status_product { get; set; }

        public int id_supplier { get; set; }

        [Required]
        [StringLength(255)]
        public string name_product { get; set; }

        public string description_product { get; set; }

        public string url_img_product { get; set; }

        public int quantity_product { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date_inserted { get; set; }

        public byte? star_review { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_detail> bill_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<price_product> price_product { get; set; }

        public virtual type_product type_product { get; set; }

        public virtual status_product status_product { get; set; }

        public virtual supplier supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sold_product> sold_product { get; set; }
    }
}

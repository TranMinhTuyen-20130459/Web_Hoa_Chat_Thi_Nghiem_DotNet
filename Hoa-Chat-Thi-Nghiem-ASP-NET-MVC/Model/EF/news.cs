namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public news()
        {
            comment_news = new HashSet<comment_news>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_news { get; set; }

        [Required]
        public string title_news { get; set; }

        [Required]
        public string content_news { get; set; }

        public string url_img_news { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date_posted { get; set; }

        public int quantity_comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment_news> comment_news { get; set; }
    }
}

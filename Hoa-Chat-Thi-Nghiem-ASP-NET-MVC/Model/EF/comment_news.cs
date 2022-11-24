namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment_news
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_comment { get; set; }

        public int id_news { get; set; }

        public int id_user_customer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime time_comment { get; set; }

        [Required]
        public string content_comment { get; set; }

        public virtual account_customer account_customer { get; set; }

        public virtual news news { get; set; }
    }
}

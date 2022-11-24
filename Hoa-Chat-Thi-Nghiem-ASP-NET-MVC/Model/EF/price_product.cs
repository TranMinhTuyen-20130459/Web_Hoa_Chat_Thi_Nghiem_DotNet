namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class price_product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_product { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime date { get; set; }

        public long listed_price { get; set; }

        public long current_price { get; set; }

        public virtual product product { get; set; }
    }
}

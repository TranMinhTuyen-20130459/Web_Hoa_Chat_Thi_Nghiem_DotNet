namespace ConnectDB.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sold_product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_product { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime datetime { get; set; }

        public int quantity_sold { get; set; }

        public virtual product product { get; set; }
    }
}

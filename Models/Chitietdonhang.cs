using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DemoProjectSem3.Models
{
    

    [Table("Chitietdonhang")]
    public partial class Chitietdonhang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int amount { get; set; }

        public int? order_id{ get; set; }

        public int? recipe_id { get; set; }

        public int? book_id{ get; set; }

        public int? total_price { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }

        public virtual Sanpham Sanpham { get; set; }
    }
}

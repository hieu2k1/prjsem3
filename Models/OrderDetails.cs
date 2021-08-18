using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DemoProjectSem3.Models
{
  

    [Table("Donhang")]
    public partial class OrderDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetails()
        {
            Chitietdonhang = new HashSet<Chitietdonhang>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public DateTime date_order { get; set; }

        public int user_id { get; set; }

        public String status { get; set; }
        

        public String description { get; set; }

        public int payment_id{ get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhang { get; set; }

        public virtual User User { get; set; }
    }
}

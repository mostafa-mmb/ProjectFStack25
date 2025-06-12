using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    [Table("SupplyOrderItem")]
    class SupplyOrderItem
    {
        [Key]
        public int ID { get; set; }
        public SupplyOrder SupplyOrder { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

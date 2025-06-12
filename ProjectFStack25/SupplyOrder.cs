using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    [Table("SupplyOrder")]
    class SupplyOrder
    {
        public SupplyOrder()
        {
            SupplyOrderItems = new HashSet<SupplyOrderItem>();
        }
        [Key]
        public int ID { get; set; }
        //public int WarehouseId { get; set; }
        public string Number { get; set; }
        public Warehouse Warehouse { get; set; }
        public DateTime Date { get; set; }
        public ICollection<SupplyOrderItem> SupplyOrderItems { get; set; }
        public Supplier Supplier { get; set; }
    }
}

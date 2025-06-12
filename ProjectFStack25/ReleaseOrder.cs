using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    [Table("ReleaseOrder")]
    class ReleaseOrder
    {
        public ReleaseOrder()
        {
            ReleaseOrderItems = new HashSet<ReleaseOrderItem>();
        }
        [Key]
        public int ID { get; set; }
        public string Number { get; set; }
        //public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ReleaseOrderItem> ReleaseOrderItems { get; set; }
        public Customer Customer { get; set; }
    }
}

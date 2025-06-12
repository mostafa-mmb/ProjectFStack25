using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    [Table("Warehouse")]
    class Warehouse
    {
        public Warehouse()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Supervisor { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

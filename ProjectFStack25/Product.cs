﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    [Table("Product")]
    class Product
    {
        [Key]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        //public ICollection<ProductMeasurementUnit> ProductMeasurementUnits { get; set; }
    }
}

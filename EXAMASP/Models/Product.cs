using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EXAMASP.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierID { get; set; }
        public string Picture { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public double UnitslnStock { get; set; }

        public string UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public int Distcountinued { get; set; }
    }
}
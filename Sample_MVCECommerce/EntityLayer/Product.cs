using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int product_Id { get; set; } 
        public string product_Name { get; set; }
        public int product_Price { get; set; }
        public string product_Stock { get; set; }
        public DateTime product_expDate { get; set; }

    }
}

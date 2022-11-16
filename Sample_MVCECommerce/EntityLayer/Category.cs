using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        [Key]
        public int category_Id { get; set; }
        public string category_Name { get; set; }
        public string category_Content { get; set; }
    }
}

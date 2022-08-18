using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class BlogDetails
    { 
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Image { get; set; }
        public int Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}

using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories { get; set; }
        public List<Menu> MenuProducts { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<Future>  Futures { get; set; }
        public List<Shop> ShopProducts { get; set; }
        public List<Blog> Blogs { get; set; }


    }
}

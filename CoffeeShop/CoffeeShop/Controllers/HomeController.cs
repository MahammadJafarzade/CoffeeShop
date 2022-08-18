using CoffeeShop.DAL;
using CoffeeShop.Models;
using CoffeeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Categories= _context.categories.ToList(),
                MenuProducts=_context.menu.ToList(),
                Discounts=_context.discounts.ToList(),
                Futures=_context.futures.ToList(),
                ShopProducts=_context.shop.ToList(),
                Blogs=_context.blogs.ToList(),

        };
            return View(home);
        }
    }
}

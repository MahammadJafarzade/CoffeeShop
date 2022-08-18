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
    public class BlogController : Controller
    {
        private AppDbContext _context { get; }
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Details()
        {
            BlogVM blogdetails = new BlogVM
            {
                blogDetails = _context.Blogdetails.ToList(),
            };
            return View(blogdetails);
        }
    }
}

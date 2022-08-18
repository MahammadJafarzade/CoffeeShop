using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {}
        public DbSet<Category> categories { get; set; }
        public DbSet<Slide> slides { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Future> futures { get; set; }
        public DbSet<Shop> shop { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogDetails> Blogdetails { get; set; }
       


    }
}

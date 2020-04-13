using Microsoft.EntityFrameworkCore;
using Models;
using System;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace CarShopDBContext
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

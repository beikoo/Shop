using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Models
{
    public class ShopDbContext : IdentityDbContext<User>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 1,
                CategoryName = "Sedan",
                CategoryDescription = ""
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 2,
                CategoryName = "Avant",
                CategoryDescription = ""
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 3,
                CategoryName = "HatchBack",
                CategoryDescription = ""
            });

            modelBuilder.Entity<Car>().HasData(new Car 
            {
                CarID=1,
                Brand = "Audi",
                Model = "Rs6",
                Price = 59999,
                Description= "25 years of RS, 25 years of high-performance station wagons from Audi: With the new Audi RS 6 Audi Sport is ushering in a new chapter in the history of the high-performance Avant. Even more power combined with increased efficiency thanks to mild hybrid system turn the RS 6 Avant into the perfect companion for any purpose. The new Audi RS 6 Avant will go on sale in dealerships in Germany and other European countries by the end of 2019.Combined fuel consumption in l / 100 km: 117(20.1) – 115(20.5),Combined CO2 emissions in g / km: 268(431.3) – 263(423.3); Information on fuel consumption and CO2 emissions aswell as efficiency classes in ranges depending on the tires and alloy wheel rims used",
                CategoryID=2,
                Image= "\\Images\\rs6.jpg",
                ThumbNail= "\\Images\\rs6.jpg",
                IsOnStock=true,
                IsOnSale=true
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarID = 2,
                Brand = "Audi",
                Model = "S8",
                Price = 80000,
                Description = "To create the S8, Audi takes its flagship A8 luxury sedan and adds a significant amount of power and poise. A standard twin-turbocharged V-8 engine provides the punch, while a firmer suspension and upgraded brakes improve the big sedan's athleticism. Subtle visual enhancements inside and out include different wheels, bumpers, and special interior trim. But the S8 otherwise looks similar to its A8 sibling, meaning that this car is not meant for those who want their luxury sedan to be ostentatious. The S8's spacious, feature-packed cabin makes it a perfect rival to V-8–powered variants of the BMW 7-series and the Mercedes-Benz S-class, and its digital dashboard makes the Audi perfect for high-rolling technophiles.",
                CategoryID = 1,
                Image = "\\Images\\s8.jpg",
                ThumbNail = "\\Images\\s8.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarID = 3,
                Brand = "Mercedes",
                Model = "AMG GT",
                Price = 180000,
                Description = "The Mercedes-AMG GT (C190 / R190) is a sports car produced in coupé and roadster bodystyles by German automobile manufacturer Mercedes-AMG. The car was introduced on 9 September 2014 and was officially unveiled to the public in October 2014 at the Paris Motor Show.[4] After the SLS AMG, it is the second sports car developed entirely in-house by Mercedes-AMG. Formula One driver Lewis Hamilton assisted with the development. The Mercedes-AMG GT went on sale in two variants (GT and GT S) in March 2015, while a GT3 racing variant of the car was introduced in 2015. A high performance variant called the GT R was introduced in 2016. A GT4 racing variant, targeted at semi-professional drivers and based on the GT R variant, was introduced in 2017. All variants are assembled at the Mercedes-Benz plant in Sindelfingen, Germany.",
                CategoryID = 1,
                Image = "\\Images\\gt.jpg",
                ThumbNail = "\\Images\\gt.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarID = 4,
                Brand = "BMW",
                Model = "I8",
                Price = 99999,
                Description = "The BMW i8 is a plug-in hybrid sports car developed by BMW. The i8 is part of BMW's electric fleet Project i being marketed as a new sub-brand, BMW i. The 2015 model year BMW i8 has a 7.1 kWh lithium-ion battery pack that delivers an all-electric range of 37 km (23 mi) under the New European Driving Cycle. Under the United States Environmental Protection Agency cycle, the range in EV mode is 24 km (15 mi) with a small amount of gasoline consumption. Its design is heavily influenced by the BMW M1 Homage concept car, which in turn pays homage to BMW's last production mid-engined sports car prior to the i8: the BMW M1. BMW will cease the production of the BMW i8 in April 2020",
                CategoryID = 1,
                Image = "\\Images\\i8.jpg",
                ThumbNail = "\\Images\\i8.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
        }
    }
}

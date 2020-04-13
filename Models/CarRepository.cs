using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class CarRepository : ICarRepository
    {
        private readonly ShopDbContext _carShopDbContext;
        public CarRepository(ShopDbContext shopDbContext)
        {
            _carShopDbContext = shopDbContext;
        }
        public IEnumerable<Car> GetAllCars 
        {
            get {
                return _carShopDbContext.Car.Include(c => c.Category); 
            }
        }

        public IEnumerable<Car> GetCarsOnSale
        {
            get
            {
                return _carShopDbContext.Car.Include(c => c.Category).Where(c => c.IsOnSale);
            }
        }

        public Car GetCarByID(int CarID)
        {
            return _carShopDbContext.Car.FirstOrDefault(c => c.CarID == CarID);
        }
    }
}

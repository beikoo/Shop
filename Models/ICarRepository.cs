using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars { get; }
        IEnumerable<Car> GetCarsOnSale { get; }
        Car GetCarByID(int CarID);
    }
}

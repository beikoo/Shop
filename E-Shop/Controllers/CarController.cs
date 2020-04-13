using E_Shop.Models;
using E_Shop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;
        public CarController(ICarRepository carRepository,ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            //return View(_carRepository.GetAllCars);
            var carListViewModel = new CarListViewModel();
            carListViewModel.Cars = _carRepository.GetAllCars;
            carListViewModel.CurrentCategory = "BestSeller";
            return View(carListViewModel);
        }

        public IActionResult Details(int id)
        {
            var details = _carRepository.GetCarByID(id);
            if (details == null)
            {
                return NotFound("dfsdfsd");
            }
            return View(details);
        }
    }
}

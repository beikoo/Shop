using E_Shop.Models;
using E_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult Index()
        {
            //return View(_carRepository.GetAllCars);
            var carListViewModel = new CarListViewModel();
            carListViewModel.Cars = _carRepository.GetAllCars;
            return View(carListViewModel);
        }
    }
}

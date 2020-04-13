using E_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopDbContext _shopDbContext;
        public CategoryRepository(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return _shopDbContext.Category;
            }
        }
    }
}
        
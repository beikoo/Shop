﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}

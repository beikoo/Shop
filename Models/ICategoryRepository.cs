using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Car> Cars { get; set; }
    }
}

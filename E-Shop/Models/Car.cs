using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string ThumbNail { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsOnStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

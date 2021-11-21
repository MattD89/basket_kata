using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Models
{
    class BasketItem
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        //public Promotion Promotion { get; set; } -- to be added
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Models
{
    class Basket
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public List<BasketItem> Items { get; set; }
    }
}

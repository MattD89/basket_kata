using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.MockDatabase
{
    class DbPrice
    {
        public List<UnitPrice> ItemPrices = new List<UnitPrice>();
        public DbPrice()
        {
            GetItemUnitPrices();
        }

        public void GetItemUnitPrices()
        {
            var prices = new List<UnitPrice>();

            UnitPrice priceA = new UnitPrice()
            {
                Id = 1,
                SKU = "A",
                Price = 10.0
            };
            prices.Add(priceA);

            UnitPrice priceB = new UnitPrice()
            {
                Id = 2,
                SKU = "B",
                Price = 10.0
            };
            prices.Add(priceB);

            UnitPrice priceC = new UnitPrice()
            {
                Id = 3,
                SKU = "C",
                Price = 40.0
            };
            prices.Add(priceC);

            UnitPrice priceD = new UnitPrice()
            {
                Id = 4,
                SKU = "D",
                Price = 55.0
            };
            prices.Add(priceD);
        }
    }
}

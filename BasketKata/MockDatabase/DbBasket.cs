using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.MockDatabase
{
    class DbBasket
    {
        public List<Basket> Baskets = new List<Basket>();

        public DbBasket()
        {
            getBaskets();
        }

        public void getBaskets()
        {
            var baskets = new List<Basket>();

            Basket basketA = new Basket()
            {
                Id = 100,
                Items = new List<BasketItem>()
                {
                   new BasketItem() 
                   { 
                        Id = 1,
                        Price = 10,
                        SKU = "A"
                   }
                },
                TotalPrice = 10
            };
            baskets.Add(basketA);

            Basket basketB = new Basket()
            {
                Items = new List<BasketItem>()
                {
                   new BasketItem()
                   {
                        Id = 1,
                        Price = 10,
                        SKU = "A"
                   },
                   new BasketItem()
                   {
                        Id = 2,
                        Price = 15,
                        SKU = "B"
                   },
                   new BasketItem()
                   {
                        Id = 3,
                        Price = 15,
                        SKU = "B"
                   },
                   new BasketItem()
                   {
                        Id = 4,
                        Price = 15,
                        SKU = "B"
                   },
                },
                TotalPrice = 50
            };
            baskets.Add(basketB);
        }

    }
}

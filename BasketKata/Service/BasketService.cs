using BasketKata.MockDatabase;
using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketKata.Service
{
    class BasketService : IBasketService
    {
        public Item GetItem(string sku)
        {
            var items = new DbItem().Items;
            return items.Where(x => x.SKU == sku).FirstOrDefault();
        }

        public UnitPrice GetPrice(string sku)
        {
            var prices = new DbPrice().ItemPrices;
            return prices.Where(x => x.SKU == sku).FirstOrDefault();
        }

        public Basket GetBasket(int id)
        {
            var basket = new DbBasket().Baskets;
            var basketMatch = basket.Where(x => x.Id == id).FirstOrDefault();
            return basketMatch ?? new Basket();
        }
    }
}

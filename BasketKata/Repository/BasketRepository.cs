using BasketKata.Models;
using BasketKata.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Repository
{
    class BasketRepository : IBasketRepository
    {
        public IBasketService _basketService;

        public BasketRepository(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public Item GetItem(string sku)
        {
            var item = _basketService.GetItem(sku);
            return item;
        }

        public UnitPrice GetItemPrice(string sku)
        {
            var price = _basketService.GetPrice(sku);
            return price;
        }
    }
}

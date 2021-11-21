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

        
        public BasketItem CreateBasketItem(string sku)
        {
            var item = GetItem(sku);
            var unitPrice = GetItemPrice(sku);

            var basketItem = new BasketItem()
            {
                Id = GenerateId(),
                Price = unitPrice.Price,
                SKU = item.SKU
                //need to add promotion prop
            };

            return basketItem;
        }

        public Basket AddItemToBasket(int id, BasketItem basketItem)
        {
            var basketInfo = _basketService.GetBasket(id);

            var basketItems = basketInfo.Items;
            basketItems.Add(basketItem);

            var basket = new Basket()
            {
                Id = basketInfo == null ? GenerateId() : basketInfo.Id,
                TotalPrice = basketItem.Price + basketInfo.TotalPrice,
                Items = basketItems
            };

            return basket;
        }

        private int GenerateId()
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 100);
            return id;
        }
    }
}

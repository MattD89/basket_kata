using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Repository
{
    interface IBasketRepository
    {
        Item GetItem(string sku);
        UnitPrice GetItemPrice(string sku);
        BasketItem CreateBasketItem(string sku);
        Basket AddItemToBasket(int id, BasketItem basketItem);
    }
}

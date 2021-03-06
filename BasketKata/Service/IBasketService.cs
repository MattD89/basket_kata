using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Service
{
    interface IBasketService
    {
        Item GetItem(string sku);
        UnitPrice GetPrice(string sku);
        Basket GetBasket(int id);
    }
}

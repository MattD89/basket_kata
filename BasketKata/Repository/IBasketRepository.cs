using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.Repository
{
    interface IBasketRepository
    {
        Item GetItem(string sku);
        UnitPrice GetItemPrice();
        
        //addItemToBasket

    }
}

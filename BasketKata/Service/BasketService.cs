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
    }
}

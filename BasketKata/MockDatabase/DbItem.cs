using BasketKata.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketKata.MockDatabase
{
    class DbItem
    {
        public List<Item> Items = new List<Item>();
        public DbItem()
        {
            GetItemTypes();
        }

        public void GetItemTypes()
        {
            var items = new List<Item>();

            Item itemA = new Item()
            {
                Id = 1,
                SKU = "A",
                HasPromotion = false
            };
            items.Add(itemA);

            Item itemB = new Item()
            {
                Id = 2,
                SKU = "B",
                HasPromotion = true
            };
            items.Add(itemB);

            Item itemC = new Item()
            {
                Id = 3,
                SKU = "C",
                HasPromotion = false
            };
            items.Add(itemC);

            Item itemD = new Item()
            {
                Id = 4,
                SKU = "D",
                HasPromotion = true
            };
            items.Add(itemD);
        }
    }
}

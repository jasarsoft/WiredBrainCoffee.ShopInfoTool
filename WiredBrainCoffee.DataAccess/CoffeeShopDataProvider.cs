﻿using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107, PaperCupsInStock = 350 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23, PaperCupsInStock = 250 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56, PaperCupsInStock = 427 };
        }
    }
}

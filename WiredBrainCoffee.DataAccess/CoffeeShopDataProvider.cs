using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeShops()
        {
            yield return new CoffeeShop {Location = "Frankfurt", BeansInStockInKg = 107};
            yield return new CoffeeShop {Location = "Freiburg", BeansInStockInKg = 23};
            yield return new CoffeeShop {Location = "Munich", BeansInStockInKg = 56};
        }
    }
}

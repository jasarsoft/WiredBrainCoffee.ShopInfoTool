using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class CoffeeShopCommandHandler: ICommandHandler
    {
        private readonly IEnumerable<CoffeeShop> _coffeeShops;
        private readonly string _line;

        public CoffeeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
        {
            _coffeeShops = coffeeShops;
            _line = line;
        }

        public void HandleCommand()
        {
            var foundCoffeShops = _coffeeShops
                .Where(x => x.Location.StartsWith(_line, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundCoffeShops.Count == 0)
            {
                Console.WriteLine($"> Command '{_line}' not found");
            }
            else if (foundCoffeShops.Count == 1)
            {
                var coffeShop = foundCoffeShops.Single();
                Console.WriteLine($"> Location: {coffeShop.Location}");
                Console.WriteLine($"> Beans in stock: {coffeShop.BeansInStockInKg} kg");
            }
            else
            {
                Console.WriteLine($"> Multiple matching coffee shop commands found:");
                foreach (var coffeeType in foundCoffeShops)
                {
                    Console.WriteLine($"> {coffeeType.Location}");
                }
            }
        }
    }
}
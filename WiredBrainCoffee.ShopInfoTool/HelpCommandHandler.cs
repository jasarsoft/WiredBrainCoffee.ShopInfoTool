using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private readonly IEnumerable<CoffeeShop> _coffeeShops;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
        {
            _coffeeShops = coffeeShops;
            throw new NotImplementedException();
        }

        public void HandleCommand()
        {
            Console.WriteLine("> Available coffee shop commands:");
            foreach (var coffeeShop in _coffeeShops)
            {
                Console.WriteLine($"> {coffeeShop.Location}");
            }
        }
    }
}
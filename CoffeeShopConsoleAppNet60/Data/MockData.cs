using CoffeeShopConsoleAppNet60.Model;
using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Data
{
    public  class MockData : ICoffeeBlend, IMilk
    {
        private List<Coffee> _coffeeList;
        public static List<Coffee> CoffeeList()
        {
            List<Coffee> coffeeListing = new List<Coffee>()
            {
                new BlackCoffee(2),
                new Cortado(4),
                new Espresso(3),
                new IcedCoffee(5),
                new Latte(2)
            };
            return coffeeListing;
        }

        public static List<Coffee> CoffeeBlends()
        {
            List<Coffee> coffeeWithBlend = new List<Coffee>()
            {

            };
            return coffeeWithBlend;
        }

        public string CoffeeBlend()
        {
            throw new NotImplementedException();
        }

        public int MlMilk()
        {
            throw new NotImplementedException();
        }

        public void FindCoffeeWithMilk()
        {
            var findCoffeeWithMilk =
                this._coffeeList.GroupBy(x => x.CoffeeType())
                .Select(coffeeGroup => new
                {
                    blendedCoffee = coffeeGroup.Key,
                    listBlendedCoffee = coffeeGroup.ToList()
                });

            foreach (var item in findCoffeeWithMilk)
            {
                Console.WriteLine($"Item: {item.blendedCoffee}");
            }
        }
    }
}

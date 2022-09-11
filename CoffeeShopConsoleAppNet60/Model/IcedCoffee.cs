using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public class IcedCoffee : Coffee, IMilk, ICoffeeBlend
    {
        private string coffeeBlend;
        public IcedCoffee(string coffeeIsBlended)
            :base()
        {
            this.coffeeBlend = coffeeIsBlended;
        }

        public IcedCoffee(int discount)
            :base(discount)
        {

        }

        public override int CoffeePrice()
        {
            return 25 - base.Discount;
        }

        public int MlMilk()
        {
            return 25;
        }

        public override string CoffeeType()
        {
            return "Iced Coffee, dobule brewed";
        }

        public override string Strength()
        {
            return "Medium";
        }

        public string CoffeeBlend()
        {
            return coffeeBlend;
        }
    }
}

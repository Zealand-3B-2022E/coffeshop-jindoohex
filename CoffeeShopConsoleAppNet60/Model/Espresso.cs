using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public class Espresso : Coffee, ICoffeeBlend
    {
        private string coffeeBlend;
        public Espresso(string coffeeIsBlended)
            :base()
        {
            this.coffeeBlend = coffeeIsBlended;
        }

        public Espresso()
        {

        }
        public Espresso(int discount)
            :base(discount)
        {

        }

        public override int CoffeePrice()
        {
            return 20;
        }

        public override string CoffeeType()
        {
            return "Espresso";
        }

        public override string Strength()
        {
            return "Incredibly strong";
        }

        public string CoffeeBlend()
        {
            return coffeeBlend;
        }
    }
}

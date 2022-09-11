using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public class Latte : Coffee, IMilk
    {
        public Latte()
            :base()
        {

        }

        public Latte(int discount)
            :base(discount)
        {

        }
        public override int CoffeePrice()
        {
            return 40 - base.Discount;
        }
        public int MlMilk()
        {
            return 200;
        }

        public override string CoffeeType()
        {
            return "Latte";
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}

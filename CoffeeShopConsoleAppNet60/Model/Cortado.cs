using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado()
            :base()
        {

        }
        public Cortado(int discount)
            :base(discount)
        {

        }
        public override int CoffeePrice()
        {
            return 25 - base.Discount;
        }
        public int MlMilk()
        {
            return 40;
        }
        public override string CoffeeType()
        {
            return "Cortado";
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}

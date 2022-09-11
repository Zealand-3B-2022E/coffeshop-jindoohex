using CoffeeShopConsoleAppNet60.Data;
using CoffeeShopConsoleAppNet60.Model;
using CoffeeShopConsoleAppNet60.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class CoffeeWorker
    {
        public void Start()
        {
            

            Console.WriteLine("Welcome to the Coffee Shop.\n");

            Console.WriteLine("Full listing of desired coffee being listed...");

            foreach (var coffeeItem in MockData.CoffeeList())
            {
                Console.WriteLine();
                Console.WriteLine(coffeeItem.ToString());

            }

            var CoffeeWithMilk = new List<IMilk>()
            {
                new Cortado(4),
                new Latte(2)
            };


        }
    }
}

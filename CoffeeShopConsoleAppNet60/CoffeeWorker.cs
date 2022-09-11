using CoffeeShopConsoleAppNet60.Data;
using CoffeeShopConsoleAppNet60.Model;
using CoffeeShopConsoleAppNet60.Service;


namespace CoffeeShopConsoleAppNet60
{
    public class CoffeeWorker
    {

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine($"HARD CODED LIST\n");

            foreach (var coffeeItem in MockData.CoffeeList())
            {
                Console.WriteLine(coffeeItem.ToString());



                if (coffeeItem is IMilk)
                {
                    IMilk cItem = coffeeItem as IMilk;
                    Console.WriteLine($"Milk:\t\t{cItem.MlMilk()} ml");
                }
                else
                {
                    Console.WriteLine($"Milk:\t\tNONE");
                }

                Console.WriteLine("---------------------------------");

            }

            var CoffeeWithMilk = new List<IMilk>()
            {
                new Cortado(4),
                new Latte(2)
            };

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Welcome to the Coffee Shop.\n");
                Console.WriteLine("Press the coffee number to add it to your order.");
                Console.WriteLine();

                Random random = new Random();
                List<Coffee> orderCoffeeList = new List<Coffee>();

                Order o = new Order(1, 11, "Bent", "Helge", true,  orderCoffeeList);

                Console.WriteLine("1. Black Coffee\n2. Cortado\n3. Espresso\n4. Iced Coffee\n5. Latte\n\n7. Current Order\n\n9. Confirm and Purchase\n");

                char input = Console.ReadKey().KeyChar;

                try
                {
                    switch (input)
                    {

                        case '1':
                            Console.Clear();
                            Console.WriteLine($"Do you want to add Black Coffee to your order?");
                            Console.WriteLine($"1. Yes");
                            Console.WriteLine($"2. No");

                            char userInput = Console.ReadKey().KeyChar;

                            switch (userInput)
                            {
                                case '1':
                                    o.AddMenuItem(new BlackCoffee(new Random().Next(1,5)));
                                    break;

                                case '2':
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Invalid input.");
                                    break;
                            }
                            Console.Clear();
                            break;


                        case '7':
                            Console.Clear();
                            Console.WriteLine();
                            foreach (Coffee coffee in orderCoffeeList)
                            {
                                Console.WriteLine(coffee.CoffeeType() + coffee.CoffeePrice());
                            }
                            break;


                        case '9':
                            Console.Clear();
                            foreach (var coffee in orderCoffeeList)
                            {
                                Console.WriteLine(o.OrderID + o.TableID + o.BaristaOrder + o.CustomerName + o.TakeAway + o.ItemCount(), "\n-----------------------------\n");
                            }
                            return;

                        //case (char)ConsoleKey.Escape:
                        //    Console.Clear();
                        //    return;

                        default:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Invalid input.");
                            Console.WriteLine();
                            break;
                    }

                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e);
                }

            }

        }
    }
}

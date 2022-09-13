using CoffeeShopConsoleAppNet60.Data;
using CoffeeShopConsoleAppNet60.Model;
using CoffeeShopConsoleAppNet60.Service;


namespace CoffeeShopConsoleAppNet60
{
    public class CoffeeWorker
    {
        public List<Coffee> selectedCoffees = new List<Coffee>();
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
                    Console.WriteLine($"Milk:\t\t#################");
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
                Console.WriteLine("1. Black Coffee\n2. Cortado\n3. Espresso\n4. Iced Coffee\n5. Latte\n\n7. Current Order\n\n9. Confirm and Purchase\n");

                Random random = new Random();

                Order o = new Order(1, 11, "Bent", "Helge", true, selectedCoffees);

                char input = Console.ReadKey().KeyChar;

                try
                {
                    switch (input)
                    {

                        case '1':
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine($"Do you want to add Black Coffee to your order?");
                            Console.WriteLine($"1. Yes");
                            Console.WriteLine($"2. No");

                            char userInput = Console.ReadKey().KeyChar;
                            //if (userInput == '1')
                            //{
                            //    o.AddMenuItem(new BlackCoffee(new Random().Next(1, 5)));
                            //}

                            switch (userInput)
                            {
                                case '1':
                                    o.AddMenuItem(new BlackCoffee(new Random().Next(1, 5)));
                                    Console.Clear();
                                    break;

                                case '2':
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Invalid input.");
                                    break;
                            }
                            break;


                        case '7':
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine($"Current Order List");
                            Console.WriteLine();

                            foreach (var coffee in selectedCoffees)
                            {
                                Console.WriteLine(coffee.ToString() + "\n-------------------------------");
                            }

                            break;


                        case '9':
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(
                                $"OrderID:\t\t{o.OrderID}\n" +
                                $"TableID:\t\t{o.TableID}\n" +
                                $"Barista:\t\t{o.BaristaOrder}\n" +
                                $"Customer:\t\t{o.CustomerName}\n" +
                                $"Take Away:\t\t{o.TakeAway}\n" +
                                $"Total Amount:\t\t{o.ItemCount()}\n" +
                                $"-------------------------------\n");
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

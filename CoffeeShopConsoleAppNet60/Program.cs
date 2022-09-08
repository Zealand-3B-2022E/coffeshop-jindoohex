// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CoffeeShopConsoleAppNet60;

CoffeeWorker theWorker = new CoffeeWorker();
theWorker.Start();

Console.WriteLine("Press any key to close the program...");
Console.ReadKey();
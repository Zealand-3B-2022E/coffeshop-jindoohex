// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CoffeeShopConsoleAppNet60;

CoffeeWorker theWorker = new CoffeeWorker();
theWorker.Start();

Console.WriteLine();
Console.WriteLine($"" + "Press any key to close the program");

// The program will close on specified key input
Console.ReadKey(true);

Console.WriteLine();
Console.WriteLine("The program will close shortly");
Thread.Sleep(3000);
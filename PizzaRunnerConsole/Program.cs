using PizzaRunner.Business.Customers;
using System;

namespace PizzaRunnerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Mario", 10000);

            Console.WriteLine($"Created account for {account.Owner()}, with balance {account.Balance()}");

            Console.ReadLine();
        }
    }
}

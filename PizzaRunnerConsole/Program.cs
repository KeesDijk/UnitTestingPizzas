using PizzaRunner.Business.Customers;
using PizzaRunnerConsole.Ioc;
using SimpleInjector;
using System;

namespace PizzaRunnerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            BootStrapper.CreateRegistrations(container);
            IAccountService accountService = container.GetInstance<IAccountService>();

            AddAccount(accountService);

            ListAllAccounts(accountService);

            Console.ReadLine();
        }

        private static void ListAllAccounts(IAccountService accountService)
        {
            foreach (Account acc in accountService.All())
            {
                Console.WriteLine($"{acc.Owner()} => {acc.Balance()}");
            }
        }

        private static void AddAccount(IAccountService accountService)
        {
            Account account = new Account("Mario", 10000);
            Console.WriteLine($"Created account for {account.Owner()}, with balance {account.Balance()}");

            accountService.Add(account);
        }
    }
}

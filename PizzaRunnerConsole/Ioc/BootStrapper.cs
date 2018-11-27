using PizzaRunner.Business.Customers;
using PizzaRunner.Data.Customers;
using SimpleInjector;

namespace PizzaRunnerConsole.Ioc
{
    public static class BootStrapper
    {
        public static void CreateRegistrations(Container container)
        {
            container.Register<IAccountRepository, AccountRepository>();
            container.Register<IAccountService, AccountService>();
            container.Verify();
        }   
    }
}
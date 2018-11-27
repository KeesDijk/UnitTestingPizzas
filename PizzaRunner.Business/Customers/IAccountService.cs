using System.Collections.Generic;

namespace PizzaRunner.Business.Customers
{
    public interface IAccountService
    {
        List<Account> All();
        void Add(Account account);
    }
}
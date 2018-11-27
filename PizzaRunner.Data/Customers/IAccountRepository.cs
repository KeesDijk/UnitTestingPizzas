using PizzaRunner.Data.Models;
using System.Collections.Generic;

namespace PizzaRunner.Data.Customers
{
    public interface IAccountRepository
    {
        List<AccountModel> All();
        void Add(AccountModel accountModel);
    }
}
using PizzaRunner.Data.Context;
using PizzaRunner.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaRunner.Data.Customers
{
    public class AccountRepository : IAccountRepository
    {
        public List<AccountModel> All()
        {
            List<AccountModel> accountModels;
            using (PizzaRunnerContext context = new PizzaRunnerContext())
            {
                accountModels = context.Accounts.ToList();
            }
            return accountModels;
        }

        public void Add(AccountModel accountModel)
        {
            using (PizzaRunnerContext context = new PizzaRunnerContext())
            {
                context.Accounts.Add(accountModel);
                context.SaveChanges();
            }
        }
    }
}
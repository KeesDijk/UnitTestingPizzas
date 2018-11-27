using PizzaRunner.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace PizzaRunner.Data.Context
{
    public class PizzaRunnerInitializer : DropCreateDatabaseIfModelChanges<PizzaRunnerContext>
    {
        

        protected override void Seed(PizzaRunnerContext context)
        {
            List<AccountModel> accounts = new List<AccountModel>
            {
                new AccountModel { Owner = "Kees", Balance = 1000000, LegacyMarker = Guid.NewGuid().ToString()},
                new AccountModel { Owner = "AnneJan", Balance = 10, LegacyMarker = Guid.NewGuid().ToString()}
            };

            accounts.ForEach(_ => context.Accounts.Add(_));
            context.SaveChanges();
        }
    }
}
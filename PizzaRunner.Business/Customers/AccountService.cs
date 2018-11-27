using PizzaRunner.Data.Customers;
using PizzaRunner.Data.Models;
using System;
using System.Collections.Generic;

namespace PizzaRunner.Business.Customers
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public List<Account> All()
        {
            List<AccountModel> accountModels = _accountRepository.All();
            List<Account> accounts = new List<Account>();

            foreach (AccountModel accountModel in accountModels)
            {
                accounts.Add(new Account(accountModel.Owner, accountModel.Balance));
            }
            return accounts;
        }

        public void Add(Account account)
        {
            AccountModel accountModel = new AccountModel
            {
                Owner = account.Owner(),
                Balance = account.Balance(),
                LegacyMarker = CreateMarker(account.Owner())
            };

            _accountRepository.Add(accountModel);
        }

        private string CreateMarker(string owner)
        {
            Random rnd = new Random();
            DateTime now = DateTime.Now;

            return $"{owner}_{now:yyyyMMdd}_{rnd.Next(1000, 9999)}";
        }
    }
}
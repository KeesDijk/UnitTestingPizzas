using System;

namespace PizzaRunner.Business.Customers
{
    public class Account
    {
        private readonly string _owner;
        private decimal _balance;

        public Account(string owner, decimal balance)
        {
            _owner = owner;
            _balance = balance;
        }

        public decimal Balance()
        {
            return _balance;
        }

        public string Owner()
        {
            return _owner;
        }

        public void WithDraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "cannot withdraw negative amount");

            _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "cannot deposit negative amount");

            _balance += amount;
        }
    }
}
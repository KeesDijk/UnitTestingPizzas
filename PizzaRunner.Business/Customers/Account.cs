using System;

namespace PizzaRunner.Business.Customers
{
    public class Account
    {
        private readonly string _owner;
        private double _balance;

        public Account(string owner, double balance)
        {
            _owner = owner;
            _balance = balance;
        }

        public double Balance()
        {
            return _balance;
        }

        public string Owner()
        {
            return _owner;
        }

        public void WithDraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "cannot withdraw negative amount");

            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "cannot deposit negative amount");

            _balance += amount;
        }
    }
}
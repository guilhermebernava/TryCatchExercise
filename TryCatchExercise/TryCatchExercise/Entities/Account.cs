using System;
using TryCatchExercise.Entities.Execptions;

namespace TryCatchExercise.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (WithDrawLimit < amount)
            {
                throw new DomainExecption("Amount bigger than Withdraw limit");
            }
            if (amount < 0)
            {
                throw new DomainExecption("Amount is negative");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance}";
        }
    }
}

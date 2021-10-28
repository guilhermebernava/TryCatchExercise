using Baseline.ImTools;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using TryCatchExercise.Entities.Execptions;

namespace TryCatchExercise.Entities
{
    internal class Account
    {
        public double _balance;
        public string _holder;
        public double _withDrawLimit;
        
        public int Number { get; set; }

        public double WithDrawLimit
        {
            get { return _withDrawLimit; }
            set
            {
                if (_withDrawLimit < 0)
                {
                    throw new DomainExecption("Withdraw limit is less than 0");
                }
                else if (_withDrawLimit >= _balance)
                {
                    throw new DomainExecption("Withdraw limit is more than balance");
                }
                _withDrawLimit = value;
            }
        }

        public string Holder
        {
            get { return _holder; }
            
            set{_holder = value;}
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value <= 0 && value != null)
                {
                    throw new DomainExecption("Error: Balance has to be more than 0 Dollars");
                }
                _balance = value;
            }

        }

        public Account() {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            _holder = holder;
            _balance = balance;
            _withDrawLimit = withDrawLimit;
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

        public void TesteHolderHasInt()
        {
            bool containsInt = _holder.Any(char.IsDigit);
            if (Regex.Match(_holder, @"\b[0-9]\w").Success)
            {
                throw new DomainExecption("Has a number in Holder");
            }
            if (containsInt)
            {
                throw new DomainExecption("Has a number in Holder");
            }
        }

        public override string ToString()
        {
            return $"New balance: {Balance}";
        }
    }
}

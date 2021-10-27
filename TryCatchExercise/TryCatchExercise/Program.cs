using System;
using TryCatchExercise.Entities;
using TryCatchExercise.Entities.Execptions;

namespace TryCatchExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter account data");
                    Account acc = new Account();
                    Console.Write("Number: ");
                    acc.Number = Int32.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    acc.Holder = Console.ReadLine();
                    Console.Write("Initial Balance: ");
                    acc.Balance = double.Parse(Console.ReadLine());
                    Console.Write("Withdraw limit: ");
                    acc.WithDrawLimit = double.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Enter amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    acc.WithDraw(withdraw);
                    Console.WriteLine(acc);
                    break;

                }
                catch (DomainExecption e)
                {
                    Console.WriteLine("Error: " + e.Message);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error Type: " + e.Message);
                }
            }
        }
    }
}

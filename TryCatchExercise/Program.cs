using System;
using TryCatchExercise.Entities;
using TryCatchExercise.Entities.Execptions;

namespace TryCatchExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter account data");
                    Console.Write("Number: ");
                    acc.Number = Int32.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    acc.Holder = Console.ReadLine();
                    acc.TesteHolderHasInt();
                    Console.Write("Initial Balance: ");
                    acc.Balance = double.Parse(Console.ReadLine());
                    Console.Write("Withdraw limit: ");
                    acc.WithDrawLimit = double.Parse(Console.ReadLine());
                    break;
                }
                catch (DomainExecption e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error Type: " + e.Message);
                    Console.WriteLine();
                }
            }
            while (true)
            {
                try
                {
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
            }
        }
    }
}

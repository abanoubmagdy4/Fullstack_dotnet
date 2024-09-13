using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace CAsequentialThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var wallet1 = new Wallet("Issam", 80);

            wallet1.RunRandomTransaction();
            Console.WriteLine("------------------");
            Console.WriteLine($"{wallet1}\n");


            wallet1.RunRandomTransaction();
            Console.WriteLine("------------------");
            Console.WriteLine($"{wallet1}\n");
            Console.ReadKey();

        }//End Of Main


    }// End Of Class Program

    class Wallet
    {
        public string Name { get; set; }
        public int Bitcoins { get; set; }
        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            Bitcoins -= amount;

        }
        public void Credit(int amount)
        {
            Bitcoins += amount;
        }

        public void RunRandomTransaction()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 };
            foreach (int amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                {
                    Debit(absValue);
                }
                else { Credit(absValue); }

                Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId}] " + $"Processor Id : {Thread.GetCurrentProcessorId()}] {amount}");
            }

        }

        public override string ToString()
        {
            return $"[ {Name} -> {Bitcoins} Bitcoins ] ";
        }
    }// End Of Namespace
}

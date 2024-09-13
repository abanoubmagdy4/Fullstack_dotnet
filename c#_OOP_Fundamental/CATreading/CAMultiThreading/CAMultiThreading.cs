using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace CAMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Name);

            Console.WriteLine($"Background Thread :{Thread.CurrentThread.IsBackground}");

            var wa = new Wallet("Abanoub", 80);
            Thread t1 = new Thread(wa.RunRandomTransaction);
            t1.Name = "T1";

            Console.WriteLine($"T1 is Background Thread  ?:{t1.IsBackground}");
            Console.WriteLine($"after decleration {t1.Name} state is {t1.ThreadState}");

            t1.Start();
            Console.WriteLine($"after start {t1.Name} state is {t1.ThreadState}");

            t1.Join();
            Console.WriteLine($"after finish {t1.Name} state is {t1.ThreadState}");


            Thread t2 = new Thread(new ThreadStart(wa.RunRandomTransaction));// "another way to declration of  thread
                                                                             // two thread running in parallel
            t2.Name = "T2";
            t2.Start();
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
            Thread.Sleep(1000);
            Bitcoins -= amount;
            Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId}-- {Thread.CurrentThread.Name} " + $"Processor Id : {Thread.GetCurrentProcessorId()}] -{amount}");


        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
            Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId}]-- {Thread.CurrentThread.Name}  " + $"Processor Id : {Thread.GetCurrentProcessorId()}] +{amount}");

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

            }

        }

        public override string ToString()
        {
            return $"[ {Name} -> {Bitcoins} Bitcoins ] ";
        }
    }// End Of Namespace
}

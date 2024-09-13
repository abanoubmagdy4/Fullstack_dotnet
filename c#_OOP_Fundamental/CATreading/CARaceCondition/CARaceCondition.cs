using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace CARaceCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            var wa = new Wallet("Abanoub", 50);
            //wa.Debit(40);
            //wa.Debit(30); // condition 30 < 10 condition  
            // parallel   
            var t1 = new Thread(() => wa.Debit(40));  // lamda expression becuase that is void method
            var t2 = new Thread(() => wa.Debit(30));
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();      

            Console.WriteLine(wa);

        }//End Of Main


    }// End Of Class Program

    class Wallet
    {
        private readonly object ConditionLock = new object();
        public string Name { get; set; }
        public int Bitcoins { get; set; }
        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public void Debit(int amount)
        {
            lock (ConditionLock) {
                if (Bitcoins >= amount) {
                    Thread.Sleep(1000);
                    Bitcoins -= amount;
                }
            }
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;

        }

       
        public override string ToString()
        {
            return $"[ {Name} -> {Bitcoins} Bitcoins ] ";
        }
    }// End Of Namespace
}

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
            var wa1 = new Wallet("Abanoub", 100);
            var wa2 = new Wallet("kero", 50);

            //wa.Debit(40);
            //wa.Debit(30); // condition 30 < 10 condition  
            // parallel   
            Console.WriteLine("\n Before Transaction ");
            Console.WriteLine("\n ---------------------");
            Console.WriteLine($"wallet one before transaction {wa1}");
            Console.WriteLine($"wallet one before transaction {wa2}");

            Console.WriteLine("\n after Transaction ");
            Console.WriteLine("\n ---------------------");

            var trnsferManager1 = new TransferManager(wa1, wa2, 50);
            var trnsferManager2 = new TransferManager(wa2, wa1, 30);

            trnsferManager1.Transfer();
            trnsferManager2.Transfer();

            Console.WriteLine($"wallet one after transaction {wa1}");
            Console.WriteLine($"wallet one after transaction {wa2}");

            var t1 = new Thread(trnsferManager1.Transfer);
            t1.Name = "T1";
            var t2 = new Thread(trnsferManager2.Transfer);
            t2.Name = "T2";

            Console.WriteLine("\n after threading ");
            Console.WriteLine("\n ----------------------");
          

            t1.Start();
            t2.Start();
           
            t1.Join();
            t2.Join();

            Console.WriteLine($"wallet one after threading  {wa1}");
            Console.WriteLine($"wallet two after threading{wa2}");

            Console.ReadKey();

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
            lock (ConditionLock)
            {
                if (Bitcoins >= amount)
                {
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
    }
    class TransferManager
    {
        private Wallet from; 
        private Wallet to;
        private int amountToTransfer;

        public TransferManager(Wallet from, Wallet to, int amountToTransfer)
        {
            this.from = from;
            this.to = to;
            this.amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock .... {from}");
            lock (from)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired .... {from}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock.... {to}");
                if (Monitor.TryEnter(to, 1000))
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired .... {to} ");
                    try
                    {

                        from.Debit(amountToTransfer);
                        to.Credit(amountToTransfer);

                    }
                    catch
                    {


                    }
                    finally
                    {

                        Monitor.Exit(to);

                    }
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired lock on .... {to} ");
                }
                    //lock (to)
                    //{
                    //    from.Debit(amountToTransfer);
                    //    to.Credit(amountToTransfer);

                    //}
                }
            }
    }
    }// End Of Namespace



using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace CALongRunningTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Factory.StartNew(() => RunLongTask(), TaskCreationOptions.LongRunning);
            Console.ReadKey();
        }//End of Main
        
        private static void showThreadInfo(Thread th)
        {

            Console.WriteLine($"Thread ID : {th.ManagedThreadId} \n Pooled :{th.IsThreadPoolThread} \n Background {th.IsBackground} ");
        }
        static void RunLongTask() { 
          Thread.Sleep(2000);
            showThreadInfo(Thread.CurrentThread);   
            Console.WriteLine("Completed");
        }
    }// End Of Class Program

}// End Of Namespace




//DESKTOP-6CNDF10\SQLEXPRESS

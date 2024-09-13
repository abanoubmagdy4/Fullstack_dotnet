using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace CAExceptionPropagation
{
    class Program
    {
        static void Main(string[] args)
        {

            //var th = new Thread(() => ThrowExcerptionWithTryCatchBlock());
            //th.Start();
            //th.Join();
            try
            {
                Task.Run(ThrowException).Wait();
            }
            catch {
                Console.WriteLine("Exception is thrown !!! .. ");
            
            }
            Console.ReadKey();
        }//End of Main

        private static void showThreadInfo(Thread th)
        {
            Console.WriteLine($"Thread ID : {th.ManagedThreadId} \n Pooled :{th.IsThreadPoolThread} \n Background {th.IsBackground} ");
        }

        static void ThrowException() { 
         throw new NullReferenceException();
         
        }
        //static void ThrowExcerptionWithTryCatchBlock() {

        //    try
        //    {
        //        ThrowException();

        //    }
        //    catch
        //    {

        //        Console.WriteLine("Exception is thrown  !!!!");

        //    }

        //}
    }// End Of Class Program


}// End Of Namespace





//DESKTOP-6CNDF10\SQLEXPRESS

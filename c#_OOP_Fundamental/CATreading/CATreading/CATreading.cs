using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace CATreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Process ID : {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Processor ID : {Thread.GetCurrentProcessorId()}");


        }//End Of Main

    }// End Of Class Program

}// End Of Namespace

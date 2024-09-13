using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace CAReportProgress
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Action <int> progress = (p) => {Console.Clear(); Console.WriteLine($"{p}%"); };
            await Copy(progress);

        }// End Of Main
        static Task Copy(Action<int> onProgressPresentChanged)
        {
            return Task.Run(() =>
             {
                 for (int i = 0; i <= 100; i++)
                 {
                     Task.Delay(100).Wait();
                     if (i % 10 == 0)
                     {

                         onProgressPresentChanged(i);
                     }
                 }
                 Console.WriteLine("Welcome ya 7bib 2lby");
             });
        }

    }// End Of Class Program

}// End Of Namespace





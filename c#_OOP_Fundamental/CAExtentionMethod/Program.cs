using System;
namespace CAExtentionMethod {
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dt = DateTime.Now;
            Console.WriteLine($" {dt} ");
            Console.WriteLine($" {dt.IsWeekEnd()} ");
            Console.WriteLine($" {dt.ISWeekDay()} ");
            // add TimeSpan to dt DateTime to implement adding interval to dt Time ;
            TimeSpan ts = new TimeSpan(2, 15, 0);
            Console.WriteLine($" {dt.Add(ts)}");
            

        }

    }

}

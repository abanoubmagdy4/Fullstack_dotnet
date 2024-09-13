using System;
using System.Diagnostics;
namespace EceptionsCA
{
    class Program {
        static void Main(string[] args)
        {


            Delivery order1 = new Delivery() { Id = 1, Address = "mallawi 214 street ", CustomerName = "makar magdy" };
            var service = new DeliveryService();
            service.Start(order1);
           Console.WriteLine(order1.ToString());
            Console.ReadKey();
        }
        static int badMethod()
        {

            var x = 2;
            var y = 0;
            return x / y;


        }
    }
    }

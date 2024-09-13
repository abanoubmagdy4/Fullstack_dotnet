using System;
namespace CASimplePizzaApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza = Pizza.Oreder("shawrma");
            Console.WriteLine(pizza);
            Console.WriteLine("====================");

            Pizza pizza1 = Pizza.Oreder(PizzaConstant.ChickenPizza);
            Console.WriteLine(pizza1);
            Console.WriteLine("====================");

            Pizza pizza2 = Pizza.Oreder(PizzaConstant.VegetrianPizza);
            Console.WriteLine(pizza2);
            Console.WriteLine("====================");

            Pizza pizza3 = Pizza.Oreder(PizzaConstant.CheesePizza);
            Console.WriteLine(pizza3);
            Console.WriteLine("====================");
            Console.WriteLine("Done");
            Console.ReadKey();

        }


    }
}

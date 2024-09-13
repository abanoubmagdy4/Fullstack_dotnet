using SalaryApp;
using System.Security.Cryptography.X509Certificates;

namespace System;

partial class SalaryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employees abanoub_magdy = new Manager(1, "abanoub magdy", 177, 1);
            Console.WriteLine(abanoub_magdy);

            Employees Mina_magdy = new Sales(2 , "mina magdy", 200 , 0.5m,10m ,2);
            Console.WriteLine(Mina_magdy);

            Employees Makar_Magdy = new Developers(3, "mina", 200, 0.5m,true);
            Console.WriteLine(Makar_Magdy);

            Employees roma = new Maintenance(4, "roma magdy", 200, 0.5m);
            Console.WriteLine(roma);


        }



    }
}






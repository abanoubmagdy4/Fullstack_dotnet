using System;
namespace GenericDelegateType {
    public delegate bool Filter<in T>(T n);
    class Program
    {
        static void Main(string[] args)
        { 
            IEnumerable<decimal> list1 = new decimal[] { 2, 5.556m, 3, 4, 8, 6, 9, 10, 12, 15, 12 };
            Console.WriteLine($"Numbers Less Than 6 is: ");
            PrintNumber(list1,n => n<6);


            Console.WriteLine($"Numbers Less Than 7 is: ");
            PrintNumber(list1, n => n<7);
            Console.WriteLine($" Even Number Only ");
            Console.WriteLine($" Even Number Only ");

            PrintNumber(list1 ,  n=> n%2==0 );
        }
        static void PrintNumber<T>(IEnumerable<T> numbers ,Filter<T> filter ) 
        
        {
            foreach (var n in numbers) {
                if ( filter(n) ) {
                    Console.WriteLine(n);       
                }  
            }
        }

    }

}

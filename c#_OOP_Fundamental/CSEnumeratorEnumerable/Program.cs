using System;
namespace CSEnumeratorEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(2, "maakar", "244strsseet");
            Test t2 = new Test(1, "makar", "214street");
            Console.WriteLine(t1 != t2);       // compare reference 
            Console.WriteLine(t1 == t2);       // compare reference 
            Console.WriteLine(t1.Equals(t2)); //  compare refe rence
            Console.WriteLine(t2.GetHashCode() == t1.GetHashCode());
           
         // to compare between two object content you should override the method Equals in Test class
         // to read an element in array we should class FiveInteger inherit from Ienumeratalbe interface and emplement getEnumerator () method

         
        }
        


    }
}

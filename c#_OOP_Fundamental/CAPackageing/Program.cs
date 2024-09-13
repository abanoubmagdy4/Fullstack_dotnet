using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace CAFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            var comments = new List<FBComment>
            {
                new FBComment {Owner = "Abanouub M" , Comment = "that is nice"  , CreatedAt = new DateTime(2024,08,13,10,30,00)},
                new FBComment {Owner = "Makar M" , Comment = "woow"  , CreatedAt = new DateTime(2024,07,11,10,30,00)}

            }; 

            foreach (var comment in comments) { 
            
               Console.WriteLine(comment);
            }
           




            Console.ReadKey();

        }//End Of Main

    }// End Of Class Program

}// End Of Namespace

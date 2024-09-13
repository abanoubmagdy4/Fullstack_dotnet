using System;
using System.Collections.Generic;
using System.IO;
namespace CAFileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            Example01();
            Example02();
        }//End Of Main

        static void Example01() {
            string path = "C:\\Users\\dell\\source\\repos\\CAFileStream\\externalFile\\Test.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine($"Length : {fs.Length} Byte (s)");
               
            }

        }
        static void Example02()
        {
            string path = "C:\\Users\\dell\\source\\repos\\CAFileStream\\externalFile\\Test.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] data = new byte[fs.Length];
                int numBytesToRead = (int) fs.Length;
            }

        }
    }// End Of Class Program

}// End Of Namespace

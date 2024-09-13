using System;
namespace CAConvert1DArrayto2DArray {
    class Program {
        static void Main(string[] args)
        {
            int[] a = {1,2,3};
            arr(a,1,3);

     Console.ReadKey();
        }

        static int[,] arr(int[] original, int m , int n)
        {
            int i = 0;
            int[,] two = new int[m, n];
            if (m * n != original.Length)
            {
                return new int[0, 0];
                Console.WriteLine("cannot convert 1D to 2D array");
            }
            else
            {
                for (int y = 0; y < m; y++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        two[y, x] = original[i];
                        Console.WriteLine($"element number {i+1} = {two[y,x]}");
                        i++;
                    }
                    Console.WriteLine("Another column");    
                }
                
            }

           
            return two;

        }

    }


}

using System;
using System.Collections.Generic;

namespace CATwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 7, 11, 15 ];
            TwoSum(arr,9);
           
            
        }//End Of Main
        public static int[] TwoSum(int[] nums, int target)
        {

            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = j + 1; i < nums.Length; i++)
                {
                    if (nums[j] + nums[i] == target)
                    {

                        return new int[2] { j, i };
                    }

                }
            }
            return new int[0];
        }
    }// End Of Class Program

}// End Of Namespace




//DESKTOP-6CNDF10\SQLEXPRESS

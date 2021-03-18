using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestInteger
{
    class Program
    {
        static int Main(string[] args)
        {
             int[] A = new int[] { 1, 9, 8, 4, 2, -7 };
            // int[] A = new int[]{ 1,2,3};
            // int[] A = new int[]{ -1,-3};
            //   int[] A = new int[]{ 8};
            var result = solution(A);
            Console.WriteLine("Result: " + result);
            return result;
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            int ret = 1;
            if (A[A.Length - 1] < 1) return ret;
            if (A[0] > 1) return ret;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == ret)
                {
                    ret++;
                    if (i + 1 < A.Length)
                    {
                        if (A[i + 1] > ret) return ret;
                    }
                }
            }
            return ret;
        }
        // public static int SmallestIntegerFunc(int[] A)
        // {
        //     int maxValue = A.Length + 1;
        //     //Removing negatives and values out of range.
        //     PrintArray(A);
        //     for (int i = 0; i < A.Length; i++)
        //     {
        //         if (A[i] <= 0 || A[i] > maxValue)
        //         {
        //             A[i] = 1;
        //         }
        //     }
        //     PrintArray(A);
        //     for (int i = 0; i < A.Length; i++)
        //     {

        //             int index = Math.Abs(A[i]) - 1;
        //             if(A[index] > 0)
        //                 A[index] *= -1;

        //     }
        //     PrintArray(A);

        //     for (int i = 0; i < A.Length; i++)
        //     {
        //         // if (A[i] > 0)
        //         // {
        //             return A[i] == i ? i : i + 1;
        //         // }
        //     }
        //     return maxValue;
        // }

        // public static void PrintArray(int[] array)
        // {
        //     Console.WriteLine("------------------");
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         Console.WriteLine(array[i]);
        //     }
        // }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOcurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {9,3,9,3,9,7, 9};
            var result = ComputeOddOcurrencesInArray(A);
            Console.WriteLine(result);
        }

        public static int ComputeOddOcurrencesInArray(int[] A)
        {
            Dictionary<int,int> ocurrencies = new Dictionary<int,int>();
            if (A.Length % 2 == 0)
            {
                throw new Exception("N is not an odd integer");
            }
            int currentIndex = 0;
            while (currentIndex < A.Length)
            {
                if(!ocurrencies.ContainsKey(A[currentIndex])){
                    ocurrencies.Add(A[currentIndex], 1);
                }
                else
                {
                    ocurrencies[A[currentIndex]] += 1;
                }
                currentIndex ++;
            }
            return ocurrencies.First(x=> x.Value == 1).Key;
        }  
    }
}

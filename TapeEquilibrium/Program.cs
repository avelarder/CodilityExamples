using System;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {3,1,2,4,3};
            var result = solution(input);
            Console.WriteLine(result);
        }

        static int solution(int[] A){
            int min = Int32.MaxValue;
            int delimiter = 1;
            while (delimiter <= A.Length - 1)
            {
                var left = Sum(A, 0, delimiter);
                var right = Sum(A, delimiter, A.Length);
                var diff = Math.Abs(left - right);
                if(diff < min)
                    min = diff;
                delimiter ++;
            }
            return min;
        }

        static int Sum(int[] A, int from, int to ){
            int sum = 0;
            for (int i = from; i < to; i++)
            {
                sum += A[i];
            }
            return sum;
        }

    }
}

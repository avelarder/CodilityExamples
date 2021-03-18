using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(10,85,30);
            var result2 = solution2(10,85,30);
            // var result = solution(1, 5, 2);
            // var result2 = solution2(1, 5, 2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        static int solution(int X, int Y, int D)
        {
            int jumps = 1;
            int sumPos = X;
            int difference = Y - X;
            if (D > Y || X == Y) return 0;
            do
            {
                if (sumPos <= Y)
                {
                    sumPos += D;
                    difference = Y - sumPos;
                }
                if (sumPos <= Y && sumPos - Y < difference)
                    jumps++;

            } while (sumPos <= Y);

            return jumps;
        }

        static int solution2(int X, int Y, int D){
            if(X != Y && D <= Y)
            {
                int jumps = (Y - X) / D;
                if((Y - X) % D > 0)
                {
                    jumps++;
                }
                return jumps;
            }
            return 0;
        }

        /*
        5-1 / 2 = 2
        85-10 / 30 = 
        */
    }
}

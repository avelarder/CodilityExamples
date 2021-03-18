using System;

namespace rotateArrayRight
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solve2(new int[] { 3, 8, 9, 7, 6 }, 3);

            Console.WriteLine(result);
        }

        public static int[] Solve(int[] A, int K)
        {
            int index = 0;
            while (index < K)
            {
                int lastElement = A[A.Length - 1];
                for (int i = A.Length - 1; i > 0; i--)
                {
                    A[i] = A[i - 1];
                }
                A[0] = lastElement;
                index++;
            }
            return A;
        }

        public static int[] Solve2(int[] A, int K)
        {
            int currentIndex = 0;
            int maxElements = A.Length;
            if(maxElements == K || K==0 || A.Length == 0 || (K > maxElements && K % maxElements == 0))
                return A;

            int currentElement = A[0];
            bool processing = true;
            while (processing)
            {
                int targetIndex = maxElements - K + 1 + currentIndex < maxElements ? maxElements - K + 1 + currentIndex : maxElements - K + 1 - maxElements + currentIndex;
                int tempValue = A[targetIndex];
                A[targetIndex] = currentElement;
                currentElement = tempValue;

                currentIndex = targetIndex;

                if (currentIndex == 0) processing = false;
            }
            return A;
        }
    }
}


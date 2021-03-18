using System;
using System.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[] { 2, 3, 1, 5 };
            // int[] inputs = new int[] { 2 };
            // int[] inputs = new int[] { 1 };
            var result = solution(inputs);
            Console.WriteLine(result);
        }

        public static int solution(int[] A)
        {
            int missing = 1;
            if(A.Length == 0) return missing;

            var sorted = A.OrderBy(x => x).ToArray();
            for (int i = 0; i < sorted.Length; i++)
            {
                if(sorted[i] > missing)
                    return missing;
                missing++;
            }
            return missing;
        }
    }
}

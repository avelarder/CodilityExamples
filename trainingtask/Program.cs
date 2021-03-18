using System;

namespace trainingtask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = solution(328);
            Console.WriteLine(result);
        }

        public static int solution(int N) {
            string binary = Convert.ToString(N, 2);    
            int maxGap = 0;
            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == '1')
                {
                    int counter = 0;
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '0')
                        {
                            counter++;
                        }    
                        else
                        {
                            if (maxGap < counter)
                            {
                                maxGap = counter;
                            }
                            i = j-1;
                            break;
                        }
                    }
                }
            }
            return maxGap;
        }
    }
}

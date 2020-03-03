using System;
using System.Collections.Generic;
using System.IO;

namespace _25RunningTimeAndComplexity
{
    class Solution
    {
        static void Main(String[] args)
        {
            Console.WriteLine("# of test cases");
            int T = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hit enter after each int");

            while (T-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i * i <= n; i++)
                {

                    if (n % i == 0)
                    {
                        n = 1;
                    }
                }

                if (n == 1)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
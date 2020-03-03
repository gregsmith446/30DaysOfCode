using System;
 
namespace _29Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("# of test cases");
            int t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} test cases needed, hit enter after each complete entry in 'number number' format", t);

            // retrieve input
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(input[0]);

                int k = Convert.ToInt32(input[1]);

                // if true, print that integer, as it is the maximum possible answer
                if ((k - 1 | k) <= n)
                {
                    Console.WriteLine(k-1);
                }
                else
                {
                    Console.WriteLine(k-2);
                }  
            }
        }
    }
}

using System;

namespace _19Interfaces
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give int now: ");
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }


    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}


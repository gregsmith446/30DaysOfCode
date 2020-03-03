using System;

class Program
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();

        Console.WriteLine("Type # of Test Cases");
        int T = Int32.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            Console.WriteLine("Type values for n and p space separated");
            string[] num = Console.ReadLine().Split();

            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);

            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}

class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");
        }
        else
        {
            return Convert.ToInt32(Math.Pow(n, p));
        }
    }
}

/*
Sample Input

4
3 5
2 4
-1 -2
-1 3

Sample Output
243
16
n and p should be non-negative
n and p should be non-negative
 */

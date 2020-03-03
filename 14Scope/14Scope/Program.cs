using System;
using System.Linq;

namespace _14Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of intergers in Array: ");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Space Separated Numbers in the Array: ");
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            // create instance of Difference Class
            Difference d = new Difference(a);

            // access the method within the Difference class
            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // A class constructor that takes an array of integers as a parameter and saves it to the elements instance variable.
        public Difference(int[] arr)
        {
            elements = arr;
        }

        // A computeDifference method that finds the maximum absolute difference between any 2 numbers in N and stores it in the maximumDifference instance variable.
        public void computeDifference()
        {
            int max = elements.Max();
            int min = elements.Min();

            Console.WriteLine(max);
            Console.WriteLine(min);

            maximumDifference = max - min;
            Console.WriteLine(maximumDifference);
        }
    }
}

/*
 
    Longer Version using foreach and if logic instead of .Max() and .Min()

     class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] arr)
        {
            elements = arr;
        }

        public void computeDifference()
        {
            int maxValue = elements[0];
            int minValue = elements[0];

            foreach (int i in elements)
            {
                if (i > maxValue)
                {
                    maxValue = i;
                }

                if (i < minValue)
                {
                    minValue = i;
                }
            }
            maximumDifference = maxValue - minValue;
        }
    }
*/

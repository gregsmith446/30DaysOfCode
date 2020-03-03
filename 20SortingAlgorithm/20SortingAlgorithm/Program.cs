using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _20SortingAlgorithm
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Type an int between 2 and 600: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give {0} space separated ints for the array: ", n);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int tempInt = 0;
            int numSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        tempInt = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = tempInt;

                        numSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numSwaps == 0)
                {
                    break;
                }
            }

            int lastInt = a.Last();

            Console.WriteLine("Array is sorted in {0} swaps.", numSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", lastInt);
        }
    }
}

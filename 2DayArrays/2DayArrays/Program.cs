using System;

namespace _2DayArrays
{
    class Solution
    {
        public static int maxGlassHour(int[][] arr)
        {
            // this has to be set to int.MinValue otherwise the program cannot handle negatives properly
            int currentHighest = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > currentHighest)
                    {
                        currentHighest = sum;
                    }
                }
            }
            return currentHighest;
        }

        /*
        to test this program in the console, you will have to give a 6 x 6 array space separated as such
        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 2 4 4 0
        0 0 0 2 0 0
        0 0 1 2 4 0

        expected output is 19
        */

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(maxGlassHour(arr));

        }
    }
}

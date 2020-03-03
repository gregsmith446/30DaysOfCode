using System;

namespace _21GenericFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give int as the size of the int array.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];

            Console.WriteLine("Give contents of int array, hitting enter after each integer.");
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Give int as the size of the string array.");
            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];

            Console.WriteLine("Give contents of string array hitting enter after each string.");
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            
            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
                Console.WriteLine(item);
        }
    }
}




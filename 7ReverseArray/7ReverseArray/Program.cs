using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of array - int");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} space separated integers", n);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Reverse(arr);

            foreach (int num in arr)
            {
                Console.Write("{0} ", num);
            }



        }
    }
}

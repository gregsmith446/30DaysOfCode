using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _28RegExPatternsDataBases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# of test cases");
            int N = Convert.ToInt32(Console.ReadLine());

            string[] namesArray = new string[N];
            int j = 0;

            Console.WriteLine("Give {0} entries in this format: firstName email", N);

            for (int i = 0; i < N; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ');

                string emailID = inputArray[1];

                if (emailID.EndsWith("@gmail.com"))
                {
                    namesArray[j] = inputArray[0];
                    j++;
                }
            }

            Array.Sort(namesArray);

            for (int k = 0; k < namesArray.Length; k++)
            {
                if (namesArray[k] != null)
                {
                    Console.WriteLine(namesArray[k]);
                }
            }
        }
    }
}



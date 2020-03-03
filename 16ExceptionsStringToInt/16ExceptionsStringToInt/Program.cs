using System;

namespace _16ExceptionsStringToInt
{
    class Program
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}


/*
 * This regex code passes the tests but doesn't use the expected error messaging thus it fails
 * make sure to include "using System.Text.RegularExpressions;"
 */

/*
 static void Main(String[] args) {

        string S = Console.ReadLine();

        // @"" regex goes in between quotes 
        // ^\d+$, start at beginning, match decimal points, more than         
        // 1 occurence, match at the end of string  
        
    if (Regex.IsMatch(S, @"^\d+$"))
        {
            Console.WriteLine(S);
        } else 
        {
            Console.WriteLine("Bad String");
        }
    }
 */

/*
 * This code passes as well but doesn't use the expected try, catch method
 */

/*
static void Main(String[] args) {

    string S = Console.ReadLine();

    var isNumeric = int.TryParse(S, out int n);

    // if string is numbers, print them
    // else 'bad string'
    if (isNumeric == true)
    {
        Console.WriteLine(S);
    } else 
    {
        Console.WriteLine("Bad String");
    }
} 
 */

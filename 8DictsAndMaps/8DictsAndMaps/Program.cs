using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8DictsAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            Console.WriteLine("# of entries adding to phonebook");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} entry/entries. Format Example: 'greg 12345678'", num);

            // split the entries into 2 parts, assigning them to a string array
            for (int i = 0; i < num; i++)
            {
                string[] dictEntries = Console.ReadLine().Split(' ');
                // add the entries into the dict as a key value pair
                PhoneBook.Add(dictEntries[0], dictEntries[1]);
            }

            String name;

            Console.WriteLine("Enter PhoneBook Queries");
            while (( name = Console.ReadLine()) != null)
            {
                try
                {
                    Console.WriteLine($"{name}={PhoneBook[name]}");
                }
                catch
                {
                    Console.WriteLine("Not found");
                    break;
                }
            }
        }
    }
}

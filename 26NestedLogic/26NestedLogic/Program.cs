using System;
using System.Globalization;

namespace _26NestedLogic
{
    class Program
    {
        static void Main(String[] args)
        {
            // using globalization, set the date format to france, as they use dd/mm/yyyy
            // this will allow us to access the date data properly in dot notation

            CultureInfo france = new CultureInfo("fr-FR");

            Console.WriteLine("Date Returned in dd mm yyyy format");
            string originalDate = Console.ReadLine();

            DateTime returnedDate = DateTime.Parse(Console.ReadLine(), france);

            Console.WriteLine("Date Expected to be Returned, the due date in dd mm yyyy format");
            DateTime expectedDate = DateTime.Parse(Console.ReadLine(), france);

            int monthsLate = returnedDate.Month - expectedDate.Month;
            int daysLate = returnedDate.Day - expectedDate.Day;

            // not late
            if (returnedDate < expectedDate)
            {
                Console.WriteLine(0);
            }
            // years late
            else if (returnedDate.Year > expectedDate.Year)
            {
                Console.WriteLine(10000);
            }
            // months late
            else if (returnedDate.Month > expectedDate.Month)
            {
                Console.WriteLine(500 * monthsLate);
            }
            // days late
            else if (returnedDate.Day > expectedDate.Day)
            {
                Console.WriteLine(15 * daysLate);
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Ex07
    {


        //members are private by default in C#
        internal static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        internal static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int getNumber(string question)
        {
            return int.Parse(getString(question));
        }

        internal static DateTime getDate(string question)
        {
            return DateTime.Parse(getString(question));
        }

        internal static DateTime getDate()
        {
            Console.WriteLine("Enter the date as dd/MM/yyyy");
            string value = Console.ReadLine();
            return DateTime.ParseExact(value, "dd/MM/yyyy", null);
        }
    }
    class NonStaticMethods
    {
        static void Main(string[] args)
        {
            /*
            DateTime is the data structure used to work with Date and Time in C#. 
            DateTime.Now property returns the current system's date and time. 
            Difference to 2 dates will return a Timespan structure. 
            Timespan contains properties that give the span of the duration in terms of days, months, minutes, Hours and so forth.
            */
            DateTime dt = Ex07.getDate();
            Console.WriteLine("The Selected date is " + dt.ToLongDateString());
            TimeSpan span = DateTime.Now - dt;
            Console.WriteLine("The Age is " + (span.Days / 365.25));
        }
    }
}

   
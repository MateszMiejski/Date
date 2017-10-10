using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime x1;
            if (!(DateTime.TryParseExact(args[0], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out x1))
                || !(DateTime.TryParseExact(args[1], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out x1)))
            {
                Console.WriteLine("Error: Invalid input values.");
            }
            else
            {

                DateTime Start_Date = DateTime.ParseExact(args[0], "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                DateTime End_Date = DateTime.ParseExact(args[1], "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                if (Start_Date <= End_Date)
                {
                    if (Start_Date.Year == End_Date.Year)
                    {
                        if (Start_Date.Month == End_Date.Month)
                        {
                            if (Start_Date.Day == End_Date.Day)
                            {
                                Console.WriteLine("Dates are similar");
                            }
                            else
                            {
                                Console.WriteLine("{0}-{1}", Start_Date.Day, End_Date.Date.ToString("d"));
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0}.{1}-{2}", Start_Date.Day, Start_Date.Month, End_Date.ToString("d"));
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}.{2}-{3}", Start_Date.Day, Start_Date.Month, Start_Date.Year, End_Date.Date.ToString("d"));
                    }
                }
                else
                {
                    Console.WriteLine("Error: The End Date is before The Start Date");
                }
            }
            Console.ReadKey();
        }
    }
}

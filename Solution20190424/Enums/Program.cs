using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {

        static void Main(string[] args)
        {


            //int weekStart = (int) Weekdays.Monday;

            //Console.WriteLine(weekStart);

            int cavab = 404;

            if (cavab == 404)
            {
                Console.WriteLine();
            }
            

            Console.Read();

        }

        enum Errors
        {
            NotFound = 404,
            InternalServer = 500,
            Something = 3
        };
        enum Weekdays { Sunday = 1, Monday, Tuesday, Wednesday=10, Thursday, Friday, Saturday };


    }
}

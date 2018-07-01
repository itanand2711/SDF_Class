using System;

namespace multipleif
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekday = 1;
            if(weekday == 1)
            {
                Console.WriteLine("Sunday");
            }
            if (weekday == 2)
            {
                Console.WriteLine("Monday");
            }
            if(weekday == 3)
            {
                Console.WriteLine("Tuesday");
            }
            if(weekday == 4)
            {
                Console.WriteLine("Wednesday");
            }
            if(weekday == 5)
            {
                Console.WriteLine("Thursday");
            }
            if(weekday == 6)
            {
                Console.WriteLine("Friday");
            }
            if (weekday == 7)
            {
                Console.WriteLine("Saturday");
            }
        }
    }
}

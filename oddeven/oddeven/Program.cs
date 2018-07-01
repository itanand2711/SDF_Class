using System;

namespace oddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("Its Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}

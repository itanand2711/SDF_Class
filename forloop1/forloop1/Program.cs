using System;

namespace forloop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("{0},", i);
                }

            }
        }
    }
}

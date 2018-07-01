using System;

namespace dowhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum, i;
            sum = 0;
            i = 0;
            do
            {
                sum = i + sum;
                i++;
            } while (i < n);
            Console.WriteLine("Sum ={0}",sum);
        }
    }
}

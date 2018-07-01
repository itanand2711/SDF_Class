using System;

namespace ifesleif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter GRADE=");
            double grade = Convert.ToDouble(Console.ReadLine());
            if(grade >= 90)
            {
                Console.WriteLine("Its A grade");
            }
            else if(grade >= 80)
            {
                Console.WriteLine("Its B grade");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Its C grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}

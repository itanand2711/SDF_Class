using System;

namespace elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = 98;
            if(points>90)
            {
                Console.WriteLine("It's A grade");
            }
            else if (points>80)
            {
                Console.WriteLine("It's B grade");
            }
            else if(points>70)
            {
                Console.WriteLine("It's C grade");
            }
            else if(points>60)
            {
                Console.WriteLine("It's D grade");
            }
            else
            {
                Console.WriteLine("Sorry, It's a E grade");
            }
        }
    }
}

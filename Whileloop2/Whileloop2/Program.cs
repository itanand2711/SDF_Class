using System;

namespace Whileloop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while(i <4)
            {
                Console.WriteLine("While");
                i++;
            }
            //do While
            int j = 5;
            do
            {
                Console.WriteLine("Do While");
            } while (j < 4);
        }
    }
}

using System;

namespace dowhileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("value of i={0}",i);
                i++;
            } while (i < 5);
        }
    }
}

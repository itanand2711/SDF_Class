using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            number[0] = 20;
            number[1] = 30;
            number[2] = 10;
            number[3] = 15;
            number[4] = 25;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}

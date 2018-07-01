using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;
            int z;
            Console.WriteLine("x={0}",x);
            Console.WriteLine("y={0}", y);
            z = x;
            x = y;
            y = z;
            Console.WriteLine("Swap");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }
    }
}

using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Please enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);
        }
    }
}

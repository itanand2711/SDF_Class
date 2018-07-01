using System;

namespace VariableString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name=");
            String s = Console.ReadLine();
            Console.WriteLine("Hello,{0}", s);
        }
    }
}

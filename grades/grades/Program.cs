using System;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = 80;
            if (grade >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if(grade >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if(grade >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade E");
            }
        }
    }
}

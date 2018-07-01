using System;

namespace Switchstatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1=");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2=");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose option:");
            Console.WriteLine("+ Add");
            Console.WriteLine("- Sub");
            Console.WriteLine("* Mul");
            Console.WriteLine("/ Div");
            string ch = Console.ReadLine();
            double answer;
            switch (ch)
            {
                case "+" :
                    answer = number1 + number2;
                    break;
                case "-":
                    answer = number1 - number2;
                    break;
                case "*":
                    answer = number1 * number2;
                    break;
                case "/":
                    answer = number1 / number2;
                    break;
                default:
                    answer = 0;
                    Console.WriteLine("!!!..Error..!!!");
                    break;
            }
            Console.WriteLine("Answer ={0}",answer);
        }
    }
}

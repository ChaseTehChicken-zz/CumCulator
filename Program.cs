using System;
using System.Net.Http.Headers;

namespace CumCulator
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Title = "CumCulator by Chaseyy";
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter an operator (+ add, - subtract, * multiply, / divide): ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                int product = num1 + num2;
                int i;
                for (i = 0; i < product; i++)
                {
                    Console.WriteLine("Cum");
                }
            }

            if (op == "-")
            {
                int product = num1 - num2;
                if (product < 0)
                {
                    Console.WriteLine("The answer cannot be less than 0");
                    goto start;
                }
                else
                {
                    int i;
                    for (i = 0; i < product; i++)
                    {
                        Console.WriteLine("Cum");
                    }
                }
            }

            if (op == "*")
            {
                int product = num1 * num2;
                if (product < 0)
                {
                    Console.WriteLine("The answer cannot be less than 0");
                    goto start;
                }
                else
                {
                    int i;
                    for (i = 0; i < product; i++)
                    {
                        Console.WriteLine("Cum");
                    }
                }
            }

            if (op == "/")
            {
                int product = num1 / num2;
                if (product < 1)
                {
                    Console.WriteLine("The answer cannot be less than 1");
                    goto start;
                }
                else
                {
                    int i;
                    for (i = 0; i < product; i++)
                    {
                        Console.WriteLine("Cum");
                    }
                }
            }

            Console.WriteLine("Type \"stop\" to end the program, or type anything else to do it again: ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                goto done;
            }
            else
            {
                goto start;
            }

        done:
            System.Environment.Exit(0);
        }
    }
}
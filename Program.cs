using System;

namespace Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100:");
            int input = int.Parse(Console.ReadLine());
            if (input > 100)
            {
                try
                {
                    Console.WriteLine("Enter a number that is 100 or less:");
                    int input3 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a number that is 100 or less");
                    Console.ReadKey(true);
                }
            }
            Console.WriteLine("Type 1 for Even numbers, or type 2 for Odd numbers:");
            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 1)
            {
                for (int i = 0; i < input; i++)
                {
                    int even = 2 * i;
                    if (even >= input)
                    {
                        break;
                    }
                    Console.WriteLine(even + " is an even number.");
                }
            }
            else 
            {
                for (int i = 0; i < input; i++)
                {
                    int odd = 2 * i + 1;
                    if (odd >= input)
                    {
                        break;
                    }
                    Console.WriteLine(odd + " is an odd number.");
                }
            }
        }
    }
}
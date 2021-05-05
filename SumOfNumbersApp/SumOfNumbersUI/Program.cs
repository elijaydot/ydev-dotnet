using System;

namespace SumOfNumbersUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfNumbers(number);
            Console.WriteLine($"The Sum of Numbers is : {sum}");
            Console.ReadKey();
        }
        static int SumOfNumbers(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumOfNumbers(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}

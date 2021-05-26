using System;
using System.Collections.Generic;

namespace Gift20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfOdd = 0;
            int sumOfEven = 0;

            List<int> Numbers = new List<int>();
            Console.WriteLine("Enter Series of numbers");
            string number = Console.ReadLine();

            string [] input = number.Split("-");
            for(int i = 0; i < input.Length; i++)
            {
                int digit = Convert.ToInt32(input[i]);
                Numbers.Add(digit);
            }

            for (int i = 0; i < Numbers.Count - 1; i ++)
            {
                if (i % 2 != 0)
                {
                    sumOfOdd += Numbers[i];
                }
                else 
                {
                    sumOfEven += Numbers[i];
                }

            }
            Console.WriteLine(sumOfEven);
            Console.WriteLine(sumOfOdd);
        }

    }
}

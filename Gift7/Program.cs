using System;
using System.Collections.Generic;

namespace Gift7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOdd = new List<string>();
            
            List<string> ListEven = new List<string>();

            List<string> ListPrime = new List<string>();

            Console.Write("Enter Series Of Numbers: ");
            string [] numbers = Console.ReadLine();

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    ListEven.Add(num.ToString());
                }
                else if (Num % 2 != 0)
                {
                    ListOdd.Add(num.ToString());
                    ListPrime.Add(num.ToString());
                }

                for (int i = 0; i < ListOdd.Count; i++)
                {
                    Console.WriteLine($"this is odd: {ListOdd[i]} ");
                }

                for (int i = 0; i < ListEven.Count; i++)
                {
                    Console.WriteLine($"this is Even: {ListEven[i]} ");
                }

                for (int i = 0; i < ListPrime.Count; i++)
                {
                    Console.WriteLine($"this is Prime: {ListPrime[i]} ");
                }

            }


        }
    }
}


using System;

namespace Gift17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter  Any Number : ");
            string input = Console.ReadLine();

                while (input.Length > 0);
                {
                    
                    int trials = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[0] == input[i])
                        {
                            trials++;
                        }
                    }
                    Console.WriteLine($"{input[0]} occurs {trials} times");
                   input = input.Replace(input[0].ToString(), string.Empty);
                }
        
        
        
      }
    }
}

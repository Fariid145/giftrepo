using System;
using System.Collections.Generic;
using System.Linq;

namespace Gift18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int>{45, 34, 23, 56, 45, 22};
            int minNum = digits.Min();
            Console.WriteLine($"Minimum digit = {minNum}");
            for(int i = 0; i < digits.Count; i++)
            {
                if(minNum == digits[i])
                {
                    Console.WriteLine($"Smllest index: {i}");
                }
            }
            
            
        }
    }
}

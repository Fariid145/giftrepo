using System;
using System.Collections.Generic;
using System.Linq;

namespace Gift10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>{300, 600, 450, 200, 250, 250};
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            int maxNum = values.AsQueryable().Max();
            int minNum = values.AsQueryable().Min();
            Console.WriteLine("Smallest number = {0}", minNum);
            Console.WriteLine("Biggest number = {0}", maxNum);

            Console.WriteLine(maxNum * minNum);
        }
    }
}

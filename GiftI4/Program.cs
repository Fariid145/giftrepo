using System;
using System.Collections.Generic;

namespace GiftI4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favorites = new List<string>{"Bread and okro", "Home Economics", "Football"};

            Console.WriteLine($"My best food is {favorites[0]}");
            Console.WriteLine();
            Console.WriteLine($"My best subject is {favorites[1]}");
            Console.WriteLine();
            Console.WriteLine($"I like playing {favorites[2]} ");
            Console.WriteLine();
        }
    }
}


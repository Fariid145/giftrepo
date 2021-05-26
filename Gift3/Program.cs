using System;
using System.Collections.Generic;

namespace Gift3
{
    List<Score> Scores = new List<Score>();
    class Program
    {
        static void Main(string[] args)
        {
            int Average = 50;
            int[] scores = { 1, 3, 4, 4, 3, 5, 7, 8, 9, 4, 4, 65, 7 };

              foreach(var score in scores)
              {
                if (score >= Average)
                {
                    Console.WriteLine($"Grade: {score} = you Scored higher than Average");
                }
                else if(score < Average)
                {
                    Console.WriteLine($"Grade: {score} = you Scored below Average");
                }
              }
            
        }
    }
}


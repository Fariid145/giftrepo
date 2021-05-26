using System;
using System.Collections.Generic;

namespace Gift
{
    class Program
    {
        List<Scores> grades = new List<Scores>();
        static void Main(string[] args)
        {
           Console.Write("Enter Your Grade: ");
            string grade = Console.ReadLine();

            switch(grade)
            {
                case "A":
                case "a":
                    Console.WriteLine("You scored 40%");
                    break;

                case "B":
                case "b":
                    Console.WriteLine("You scored 30%");
                    break;

                case "C":
                case "c":
                    Console.WriteLine("You scored 20%");
                    break;

                case "D":
                case "d":
                    Console.WriteLine("You scored 10%");
                    break;

                default:
                if (grade == "F" )
                   { 
                       Console.WriteLine("You failed");
                   }
                   else
                   {
                        Console.WriteLine("Invalid Expretion");
                   }
                    break;
            }
        }
    }
}

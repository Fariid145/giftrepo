using System;
using System.Collection.Generic;
namespace Gift19
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> Order = new List<int>();
           Console.WriteLine("Enter series of  numbers");
           string input = Console.ReadLine();
           string [] userOptions = input.Split("-");

           for (int i = 0; i < userOptions.Length; i ++)
           {
               int numbers = Convert.ToInt32(userOptions[i]);
               Order.Add(numbers);
           }
           if(Order[0] > Order[1] && Order[1] < Order[2] || Order[0] < Order[1] && Order[1] > Order[2])
           {
               Console.WriteLine("The List is arranged in no specific order");
           }
           else if(Order[0] > Order[1])
           {
               Console.Writeline("The List is arranged in Ascending order");
           }
           else if(Order[1] > Order[0])
           {
               Console.WriteLine("It is in descending order");
           }
        }
    }
}

using System;

namespace Gift8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> referesh = new List<string>();

            Console.WriteLine("Enter Numbers");
            string input = Console.ReadLine();

            
            referesh.Add(input);

            for (int i = 0; i < referesh.Count; i++)
            {
                Console.WriteLine(referesh[i]);
            }

        } 
    }
}

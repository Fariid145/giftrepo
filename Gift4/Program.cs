using System;
using System.Collections.Generic;

namespace Gift4
{
    class Program
    {
        static void Main(string[] args)
        {
    

            bool istrue = true;

            List<int> occurence = {88, 44, 66, 88, 7, 0 ,8, 8, 6 };

    
            for (int i = 0; i < occurence.Count; i++)
            {
                if (occurence[0] == occurence[i])
                {
                    Console.WriteLine(istrue == false);
                }
                else
                {
                    Console.WriteLine(istrue);
                }
            }


        }
    }
}


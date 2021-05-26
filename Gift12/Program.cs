using System;
using System.Collections.Generic;
using System.Linq;

namespace Gift12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
     
           int n = 0;
           int i = 0;
           int j = 0;
           int largest;
           int secLargest;

           Console.WriteLine("Enter The Element of the array");
           string chest = Console.ReadLine().Split("-");

           Console.WriteLine("input {0} Elements in  List:\n",n);

           for(i = 0; i < n; i++)
           {
               Console.WriteLine("Elements - {0} :",i);
               num[i] = Convert.ToInt32(Console.ReadLine());
           }

           largest = 0;

           for (i = 0; i < n; i++)
           {
               if(largest < num[i])
               {
                   largest = num[i];
                   j = i;
               }
           }

           secLargest = 0;
           for (i = 0; i < n; i ++)
           {
               if(1 == j)
               {
                  i++;
                  i--;
               }
               else
               {
                   if(secLargest < num[i])
                   {
                       secLargest = num[i];
                   }
               }
           }
            Console.WriteLine("The second Largest Element in the List is : {0}\n\n", secLargest);

        //     lrg3nd=0;
        //    for (i=0;i<n;i++)
        //    {
        //        if(1==j)
        //        {
        //           i++;
        //           i--;
        //        }
        //        else
        //        {
        //            if(lrg3nd<num[i])
        //            {
        //                lrg3nd=num[i];
        //            }
        //        }
        //    }

          
          
             




        }
    }
}

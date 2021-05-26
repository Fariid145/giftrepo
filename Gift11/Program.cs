using System;

namespace Gift11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>{9, 23, 47, 55, 69, 86, 73, 87, 98};

            int swapPlace;
            swapPlace = nums[0];
            nums[0] = nums[8];
            nums[8] = swapPlace;

            Console.WriteLine("Swapping");
            Console.WriteLine("First Number: " + nums[0]);
            Console.WriteLine("Second Number: " + nums[8]);

        }
    }
}

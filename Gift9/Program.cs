
using System;

namespace Gift9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deck ;
            do
            {
                deck = new int[52];
                RandomCards(deck);
            
            }
            while(sum(deck) != 24);
            Console.WriteLine(deck);
            
        }
        public static void RandomCards(int[] deck)
        {
            for(int i = 0; i < 4; i++)
            {
                deck[(int)(Math.Random() * 52)]++;
                Sum();
            }
        }
        public static int Sum(int[] deck)
        {
            int sum = 0;
            for(int i = 0; i < deck.Length; i++)
            {
                sum += ((i + 1) % 13) * deck[i];
            }
            return sum;
            Show();
        }
        public static void Show(int[] deck)
        {
            string[] ranks = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"};
            Console.WriteLine("The number of card picked that yeild the sum of 24:");
            for(int i = o; i < deck.Length; i ++)
            {
                if(deck[i] > 0)
                {
                    Console.WriteLine(ranks[i % 13] + " ");
                        
                }
                
            }
            
        }
    }
}

// https://codeforces.com/problemset/problem/462/B

using System;
using System.Collections.Generic;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input_string = Console.ReadLine().Split();
            long n = Convert.ToInt64(input_string[0]);
            long k = Convert.ToInt64(input_string[1]);

            string input_string2 = Console.ReadLine();
            char[] input_charList = input_string2.ToCharArray();

            int[] charGroups = input_charList.GroupBy(x => x).OrderByDescending(y => y.Count()).Select(z => z.Count()).ToArray();

            long result = 0;
            long remainingCards = k;
            
            foreach (long count in charGroups)
            {
                if (count >= remainingCards)
                {
                    result = result + (remainingCards * remainingCards);
                    remainingCards = 0;
                    break;
                }
                else
                {
                    result = result + (count * count);
                    remainingCards = remainingCards - count;
                }
            }

            Console.WriteLine(result);
        }
    }
}
// https://codeforces.com/problemset/problem/363/A
using System;

namespace Codeforces
{

    class Program
    {
        static void Main(string[] args)
        {
            int given_number = int.Parse(Console.ReadLine());

            if (given_number == 0)
            {
                Console.WriteLine("O-|-OOOO");
                return;
            }

            while (given_number != 0)
            {
                int rightmost_digit = given_number % 10;
                given_number /= 10;

                if (rightmost_digit < 5)
                {
                    Console.Write("O-|");

                    for (int i = 0; i < rightmost_digit; i++)
                    {
                        Console.Write('O');
                    }

                    Console.Write('-');

                    for (int i = 0; i < 4-rightmost_digit; i++)
                    {
                        Console.Write('O');
                    }

                    Console.WriteLine();
                }

                else{
                    Console.Write("-O|");
                    rightmost_digit -= 5;

                    for (int i = 0; i < rightmost_digit; i++)
                    {
                        Console.Write('O');
                    }

                    Console.Write('-');

                    for (int i = 0; i < 4-rightmost_digit; i++)
                    {
                        Console.Write('O');
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}


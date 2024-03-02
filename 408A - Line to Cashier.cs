using System;
class Codeforces
{
    public static void Main(String[] args)
    {
        int number_of_cashier = Convert.ToInt32(Console.ReadLine());
        int[] customers_list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int minTime = Int32.MaxValue;

        for (int i = 0; i < number_of_cashier; i++)
        {
            int[] number_of_items_list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int time = 0;

            for (int j = 0; j < customers_list[i]; j++)
            {
                time += number_of_items_list[j] * 5 + 15;
            }

            minTime = Math.Min(minTime, time);
        }
        
        Console.WriteLine(minTime);
    }
}
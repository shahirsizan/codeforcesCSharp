using System;
using System.Linq;
namespace Codeforces
{
    class Problem
    {
        public static void Main()
        {
            string[] inputs_array = Console.ReadLine().Trim().Split(' ');
            int buy_opportunities_count = int.Parse(inputs_array[0]);
            int sell_opportunities_count = int.Parse(inputs_array[1]);
            int money_at_beginning = int.Parse(inputs_array[2]);

            inputs_array = Console.ReadLine().Trim().Split(' ');
            int[] buying_prices_array = Array.ConvertAll(inputs_array, int.Parse);

            inputs_array = Console.ReadLine().Trim().Split(' ');
            int[] selling_prices_array = Array.ConvertAll(inputs_array, int.Parse);

            int min_buying_price = buying_prices_array.Min();
            int max_selling_price = selling_prices_array.Max();




            if (min_buying_price >= max_selling_price)
            {
                Console.WriteLine(money_at_beginning);
                return;
            }

            int number_of_shares_bought_at_min_price = money_at_beginning / min_buying_price;
            int remaining_bourles = money_at_beginning - number_of_shares_bought_at_min_price * min_buying_price;
            int bourles_after_evening = remaining_bourles + number_of_shares_bought_at_min_price * max_selling_price;

            Console.WriteLine(bourles_after_evening);

        }

    }

}


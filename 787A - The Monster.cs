using System;

public class hello
{
    static void Main()
    {
        string[] input_string = Console.ReadLine().Trim().Split(' ');
        var ricks_interval = int.Parse(input_string[0]);
        var rick_initial_scream_time = int.Parse(input_string[1]);
        input_string = Console.ReadLine().Trim().Split(' ');
        var mortys_interval = int.Parse(input_string[0]);
        var morty_initial_scream_time = int.Parse(input_string[1]);

        var hastsett = new HashSet<int>();


        var p = morty_initial_scream_time;
        hastsett.Add(p);
        for (int i = 0; i < 100; i++)
        {
            p += mortys_interval;
            hastsett.Add(p);
        }

        int q = rick_initial_scream_time;
        for (int i = 0; i < 100; i++)
        {
            if (hastsett.Contains(q))
            {
                Console.WriteLine(q); 
                return;
            }
            q += ricks_interval;
        }

        Console.WriteLine(-1);
    }
}
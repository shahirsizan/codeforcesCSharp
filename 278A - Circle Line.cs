namespace Circle_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int no_of_stations = Convert.ToInt32(Console.ReadLine());
            int[] distances_array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int clockwise_path = 0, anticlockwise_path = 0, counter = 0;

            string[] query_array = Console.ReadLine().Split(' ');   // this array holds the starting and ending station number from input
            int startingStation = Convert.ToInt32(query_array[0]);
            int endingStation = Convert.ToInt32(query_array[1]);

            if (startingStation != endingStation)
            {
                // For anticlockwise path
                counter = startingStation - 1;
                if (counter == 0)
                {
                    counter = no_of_stations;
                }

                while (counter != endingStation - 1)
                {
                    if (counter == 0)
                    {
                        counter = no_of_stations;
                    }
                    anticlockwise_path += distances_array[counter - 1];
                    counter -= 1;
                }

                
                // For clockwise path

                counter = startingStation;
                while (counter != endingStation)
                {
                    clockwise_path += distances_array[counter - 1];
                    counter += 1;
                    if (counter == no_of_stations + 1)
                    {
                        counter = 1;
                    }
                }
            }

            Console.WriteLine(Math.Min(clockwise_path, anticlockwise_path));
            //Console.ReadLine();
        }
    }
}

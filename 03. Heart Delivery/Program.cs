using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] town = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] cmd = Console.ReadLine().Split();

            int location = 0;
            int counter = 0;

            bool isFailed = false;

            while (cmd[0] != "Love!")
            {
                if (cmd[0] == "Jump")
                {
                    location += int.Parse(cmd[1]);
                    if (location >= 0 && location < town.Length)
                    {
                        AddHarts(town, location);
                    }
                    else
                    {
                        location = 0;
                        AddHarts(town, location);
                    }
                }

                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {location}.");

            for (int i = 0; i < town.Length; i++)
            {
                if (town[i] != 0)
                {
                    isFailed = true;
                    counter++;
                }
            }

            if (isFailed)
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }

        }

        static void AddHarts(int[] town, int location)
        {
            if (town[location] != 0)
            {
                town[location] -= 2;
                if (town[location] == 0)
                {
                    Console.WriteLine($"Place {location} has Valentine's day.");
                }
            }
            else
            {
                Console.WriteLine($"Place {location} already had Valentine's day.");
            }
        }

    }
}

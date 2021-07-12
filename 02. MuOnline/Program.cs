using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

        https://judge.softuni.bg/Contests/Practice/Index/2028#1

            string[] rooms = Console.ReadLine().Split("|");
            string[] temp = new string[2];

            int playerHelth = 100;
            int playerBitcoins = 0;
            int healed = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                temp = rooms[i].Split();
                if (temp[0] == "chest")
                {
                    playerBitcoins += int.Parse(temp[1]);
                    Console.WriteLine($"You found {temp[1]} bitcoins.");
                }
                else if (temp[0] == "potion")
                {
                    healed = playerHelth;
                    playerHelth += int.Parse(temp[1]);
                    if (playerHelth > 100)
                    {
                        playerHelth = 100;
                    }
                    healed = -1 * (healed - playerHelth);
                    Console.WriteLine($"You healed for {healed} hp.");
                    Console.WriteLine($"Current health: {playerHelth} hp.");
                }
                else
                {
                    if (int.Parse(temp[1]) >= playerHelth)//without return
                    {
                        Console.WriteLine($"You died! Killed by {temp[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        playerHelth -= int.Parse(temp[1]);
                        Console.WriteLine($"You slayed {temp[0]}.");
                    }
                }
                if (i == rooms.Length - 1)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {playerBitcoins}");
                    Console.WriteLine($"Health: {playerHelth}");
                }
            }

        }
    }
}

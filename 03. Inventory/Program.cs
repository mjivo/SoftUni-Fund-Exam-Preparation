using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

        https://judge.softuni.bg/Contests/Practice/Index/2028#2

            List<string> items = Console.ReadLine().Split(", ").ToList();

            string[] cmd = Console.ReadLine().Split(" - ");
            string[] temp = new string[2];

            while (cmd[0] != "Craft!")
            {
                switch (cmd[0])
                {
                    case "Collect":
                        if (!(items.Contains(cmd[1])))
                        {
                            items.Add(cmd[1]);
                        }
                        break;
                    case "Drop":
                        items.Remove(cmd[1]);
                        break;
                    case "Combine Items":
                        temp = cmd[1].Split(":");
                        if (items.Contains(temp[0]))
                        {
                            items.Insert(items.FindIndex(x => x == temp[0]) + 1, temp[1]);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(cmd[1]))
                        {
                            items.Remove(cmd[1]);
                            items.Add(cmd[1]);
                        }
                        break;

                }

                cmd = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", items));

        }
    }
}

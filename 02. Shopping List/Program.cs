using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> products = Console.ReadLine().Split("!").ToList();

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "Go")
            {
                switch (cmd[0])
                {
                    case "Urgent":
                        if (!products.Contains(cmd[1]))
                        {
                            products.Insert(0, cmd[1]);
                        }
                        break;
                    case "Unnecessary":
                        products.Remove(cmd[1]);
                        break;
                    case "Correct":
                        if (products.Contains(cmd[1]))
                        {
                            products.Insert(products.FindIndex(x => x == cmd[1]), cmd[2]);
                            products.Remove(cmd[1]);
                        }
                        break;
                    case "Rearrange":
                        if (products.Contains(cmd[1]))
                        {
                            products.Remove(cmd[1]);
                            products.Add(cmd[1]);
                        }
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", products));

        }
    }
}

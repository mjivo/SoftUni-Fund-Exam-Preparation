using System;
using System.Linq;
using System.Collections.Generic;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split(" | ").ToList();

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "Stop!")
            {
                switch (cmd[0])
                {
                    case "Join":
                        if (!list.Contains(cmd[1]))
                        {
                            list.Add(cmd[1]);
                        }
                        break;
                    case "Drop":
                        list.Remove(cmd[1]);
                        break;
                    case "Replace":
                        if (list.Contains(cmd[1]))
                        {
                            if (!list.Contains(cmd[2]))
                            {
                                list.Insert(list.FindIndex(x => x == cmd[1]),cmd[2]);
                                list.Remove(cmd[1]);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",list));

        }
    }
}

using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] cmd = Console.ReadLine().Split();

            int temp = 0;

            while (cmd[0] != "end")
            {
                switch (cmd[0])
                {
                    case "swap":
                        temp = array[int.Parse(cmd[1])];
                        array[int.Parse(cmd[1])] = array[int.Parse(cmd[2])];
                        array[int.Parse(cmd[2])] = temp;
                        break;
                    case "multiply":
                        array[int.Parse(cmd[1])] = array[int.Parse(cmd[1])] * array[int.Parse(cmd[2])];
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i]--;
                        }
                        break;
                }

                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", array));

        }
    }
}

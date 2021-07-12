using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            int index = 0;
            int counter = 0;

            while (cmd != "End")
            {
                index = int.Parse(cmd);
                if (index >= 0 && index < array.Length)
                {
                    if (array[index] != -1)
                    {
                        counter++;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] != -1 && i != index)
                            {
                                if (array[i] > array[index])
                                {
                                    array[i] -= array[index];
                                }
                                else if (array[i] <= array[index])
                                {
                                    array[i] += array[index];
                                }
                            }
                        }
                        array[index] = -1;
                    }
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", array)}");

        }
    }
}

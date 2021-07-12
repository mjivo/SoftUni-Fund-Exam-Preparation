using System;
using System.Linq;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] items = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int indexOfEntruPoint = int.Parse(Console.ReadLine());

            string value = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;

            if (value == "cheap")
            {
                for (int i = 0; i < indexOfEntruPoint; i++)
                {
                    if (items[i] < items[indexOfEntruPoint])
                    {
                        leftSum += items[i];
                    }
                }
                for (int i = indexOfEntruPoint; i < items.Length; i++)
                {
                    if (items[i] < items[indexOfEntruPoint])
                    {
                        rightSum += items[i];
                    }
                }
            }
            else if (value == "expensive")
            {
                for (int i = 0; i < indexOfEntruPoint; i++)
                {
                    if (items[i] >= items[indexOfEntruPoint])
                    {
                        leftSum += items[i];
                    }
                }
                for (int i = indexOfEntruPoint+1; i < items.Length; i++)
                {
                    if (items[i] >= items[indexOfEntruPoint])
                    {
                        rightSum += items[i];
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else if (leftSum < rightSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }
    }
}

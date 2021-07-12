using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;

            List<int> bigerThanAvg = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > avg)
                {
                    bigerThanAvg.Add(array[i]);
                }
            }
            if (bigerThanAvg.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            bigerThanAvg.Sort();
            for (int i = bigerThanAvg.Count - 1; i >= 0 && bigerThanAvg.Count - i <= 5; i--)
            {
                Console.Write(" " + bigerThanAvg[i]);
            }

        }
    }
}

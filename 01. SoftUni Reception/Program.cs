using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {

            int employ1 = int.Parse(Console.ReadLine());
            int employ2 = int.Parse(Console.ReadLine());
            int employ3 = int.Parse(Console.ReadLine());

            int N = employ1 + employ2 + employ3;

            double peopleCount = double.Parse(Console.ReadLine());

            int time = 0;

            while (peopleCount > 0)
            {
                peopleCount -= N;
                time++;

                if (time % 4 == 0)
                {
                    time++;
                }
            }

            Console.WriteLine($"Time needed: {time}h.");

        }
    }
}

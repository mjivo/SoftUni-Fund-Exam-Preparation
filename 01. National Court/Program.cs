using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] efficiency = new int[3];
            efficiency[0] = int.Parse(Console.ReadLine());
            efficiency[1] = int.Parse(Console.ReadLine());
            efficiency[2] = int.Parse(Console.ReadLine());
            int overallEfficiency = efficiency[0] + efficiency[1] + efficiency[2];

            double peopleCount = int.Parse(Console.ReadLine());

            int TimeNeeded = 0;

            while (peopleCount > 0)
            {
                peopleCount -= overallEfficiency;
                TimeNeeded++;

                if (TimeNeeded % 4 == 0)
                {
                    TimeNeeded++;
                }
            }

            Console.WriteLine($"Time needed: {TimeNeeded}h.");

        }
    }
}

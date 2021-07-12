using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {

        https://judge.softuni.bg/Contests/Practice/Index/2028#0

            int numOfStudents = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double attendances = 0;
            double total = 1;
            double maxPoints = 0;

            for (int i = 1; i <= numOfStudents; i++)
            {
                attendances = int.Parse(Console.ReadLine());

                total = attendances / lectures * (5 + bonus);

                if (maxPoints <= total)
                {
                    maxPoints = total;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxPoints)}.");
            Console.WriteLine($"The student has attended {maxPoints * lectures / (5 + bonus)} lectures.");

        }
    }
}

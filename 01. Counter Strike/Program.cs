using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());
            string cmd = Console.ReadLine();

            int winCounter = 0;

            while (cmd != "End of battle")
            {
                if (energy >= int.Parse(cmd))
                {
                    energy -= int.Parse(cmd);
                    winCounter++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCounter} won battles and {energy} energy");
                    return;
                }

                if (winCounter % 3 == 0)
                {
                    energy += winCounter;
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {winCounter}. Energy left: {energy}");

        }
    }
}

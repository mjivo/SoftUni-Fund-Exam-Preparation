using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] cmd = Console.ReadLine().Split();

            int index = 0;
            int indexL = 0;
            int indexR = 0;
            int numOfmoves = 0;

            while (cmd[0] != "End")
            {
                switch (cmd[0])
                {
                    case "Shoot":
                        if (correctIndex(int.Parse(cmd[1]), list))
                        {
                            if (list[int.Parse(cmd[1])] > int.Parse(cmd[2]))
                            {
                                list[int.Parse(cmd[1])] -= int.Parse(cmd[2]);
                            }
                            else
                            {
                                list.RemoveAt(int.Parse(cmd[1]));
                            }
                        }
                        break;
                    case "Add":
                        if (correctIndex(int.Parse(cmd[1]), list))
                        {
                            list.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        if (correctIndex(int.Parse(cmd[1]), list))
                        {
                            index = int.Parse(cmd[1]) - 1;

                            while (correctIndex(index, list))
                            {
                                indexL++;
                                index--;
                            }

                            index = int.Parse(cmd[1]) + 1;

                            while (correctIndex(index, list))
                            {
                                indexR++;
                                index++;
                            }

                            if (indexL >= int.Parse(cmd[2]))
                            {
                                numOfmoves += int.Parse(cmd[2]);
                            }
                            else if (indexL < int.Parse(cmd[2]))
                            {
                                MissedStrike();
                                break;
                            }
                            if (indexR >= int.Parse(cmd[2]))
                            {
                                numOfmoves += int.Parse(cmd[2]);
                            }
                            else if (indexR < int.Parse(cmd[2]))
                            {
                                MissedStrike();
                                break;
                            }

                            for (int i = 0; i < numOfmoves + 1; i++)
                            {
                                list.RemoveAt(int.Parse(cmd[1]) - int.Parse(cmd[2]));
                            }
                        }
                        else
                        {
                            MissedStrike();
                        }
                        break;
                }

                indexR = 0;
                indexL = 0;
                numOfmoves = 0;

                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine($"{string.Join("|", list)}");

        }

        private static void MissedStrike()
        {
            Console.WriteLine("Strike missed!");
        }

        private static bool correctIndex(int index, List<int> list)
        {
            if (index >= 0 && index < list.Count)
            {
                return true;
            }
            return false;
        }
    }
}

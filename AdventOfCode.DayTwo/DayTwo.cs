using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.DayTwo
{
    public static class DayTwo
    {
        public static void Run(string inputPath)
        {
            var score = GetGameScore(inputPath);
            Console.WriteLine(score);
        }

        private static int GetGameScore(string inputPath)
        {
            using var sr = File.OpenText(inputPath);
            string? line;
            int currentScore = 0;
            while ((line = sr.ReadLine()) != null)
            {
                currentScore += GetRoundScore(line);
            }
            return currentScore;
        }

        private static int GetRoundScore(string round)
        {
            var plays = round.Split(' ');
            if (plays[0] == "A")
            {
                if (plays[1] == "X") return 3;
                if (plays[1] == "Y") return 4;
                return 8;
            }
            else if (plays[0] == "B")
            {
                if (plays[1] == "X") return 1;
                if (plays[1] == "Y") return 5;
                return 9;
            }
            else
            {
                if (plays[1] == "X") return 2;
                if (plays[1] == "Y") return 6;
                return 7;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.DayThree
{
    public static class DayThree
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
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
                if (lines.Count == 3)
                {
                    currentScore += GetRucksackScore(lines);
                    lines.Clear();
                }
            }
            return currentScore;
        }

        private static int GetRucksackScore(List<string> line)
        {
            var 

            var compartment1 = line[..(line.Length / 2)].ToList<char>();
            var compartment2 = line.Substring(line.Length / 2, line.Length / 2).ToList<char>();

            var common = compartment1.Where(x => compartment2.Contains(x)).First();

            var score = char.ToUpper(common) - 64;
            if (common == char.ToUpper(common)) score += 26;

            return score;
        }
    }
}

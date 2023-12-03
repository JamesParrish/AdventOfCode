using System.Text.RegularExpressions;
using AdventOfCode.Helpers;

namespace AdventOfCode.Days
{
    public class Day1 : IDay
    {
        private readonly IFileHelper _fileHelper;

        public Day1(IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }
        public void Process1Star()
        {
            var lines = _fileHelper.GetFileLines("Day1.txt");

            var digitPattern = @"\d";

            var total = 0;

            foreach (var line in lines)
            {
                var digits = Regex.Matches(line, digitPattern);

                var firstValue = digits.First().Value;
                var lastValue = digits.Last().Value;

                var concatenatedValue = $"{firstValue}{lastValue}";

                //Console.WriteLine($"{firstValue} + {lastValue} = {concatenatedValue}");

                total += Convert.ToInt16(concatenatedValue);
            }

            Console.WriteLine($"Total value: {total}");
        }

        public void Process2Star()
        {
            var lines = _fileHelper.GetFileLines("Day1.txt");

            var total = 0;

            foreach (var line in lines)
            {
                var matches = GetMatches(line);
                matches = matches.OrderBy(x => x.Index);

                var firstValue = GetValue(matches.First().Value);
                var lastValue = GetValue(matches.Last().Value);

                var concatenatedValue = $"{firstValue}{lastValue}";

                total += Convert.ToInt16(concatenatedValue);
            }

            Console.WriteLine($"Total value: {total}");
        }

        private IEnumerable<Match> GetMatches(string line)
        {
            var patterns = new List<string>
            {
                @"\d",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };

            var matches = new List<Match>();

            foreach (var pattern in patterns)
            {
                matches.AddRange(Regex.Matches(line, pattern));
            }

            return matches;
        }

        private string GetValue(string input)
        {
            switch (input)
            {
                case "one": return "1";
                case "two": return "2";
                case "three": return "3";
                case "four": return "4";
                case "five": return "5";
                case "six": return "6";
                case "seven": return "7";
                case "eight": return "8";
                case "nine": return "9";
                default: return input;
            }
        }
    }
}

using AdventOfCode.Enums;
using AdventOfCode.Helpers;

namespace AdventOfCode.Days
{
    public class Day2 : IDay
    {
        public DayEnum Day => DayEnum.Day2;

        private readonly IFileHelper _fileHelper;

        public Day2(IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }

        public void Process1Star()
        {
            Console.WriteLine("Processing Day 2 - 1 Star");
        }

        public void Process2Star()
        {
            Console.WriteLine("Processing Day 2 - 2 Star");
        }
    }
}

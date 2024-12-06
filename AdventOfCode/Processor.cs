using AdventOfCode.Enums;
using AdventOfCode.Factories;

namespace AdventOfCode
{
    public class Processor : IProcessor
    {
        private readonly IDayFactory _factory;

        public Processor(IDayFactory factory)
        {
            _factory = factory;
        }

        public void Process()
        {
            ProcessDay(DayEnum.Day1);
            ProcessDay(DayEnum.Day2);
            ProcessDay(DayEnum.Day3);
        }

        private void ProcessDay(DayEnum dayEnum)
        {
            var dayResult = _factory.GetDay(dayEnum);

            if (dayResult.IsError)
            {
                Console.WriteLine($"Day not found for day {dayEnum}");
                return;
            }

            var day = dayResult.Value;

            day.Process1Star();
            day.Process2Star();
        }
    }
}

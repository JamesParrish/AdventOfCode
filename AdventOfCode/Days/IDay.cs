using AdventOfCode.Enums;

namespace AdventOfCode.Days
{
    public interface IDay
    {
        DayEnum Day { get; }
        void Process1Star();
        void Process2Star();
    }
}

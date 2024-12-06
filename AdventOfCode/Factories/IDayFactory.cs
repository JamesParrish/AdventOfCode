using AdventOfCode.Days;
using AdventOfCode.Enums;
using ErrorOr;

namespace AdventOfCode.Factories
{
    public interface IDayFactory
    {
        ErrorOr<IDay> GetDay(DayEnum day);
    }
}

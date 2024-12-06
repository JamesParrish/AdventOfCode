using AdventOfCode.Days;
using AdventOfCode.Enums;
using ErrorOr;

namespace AdventOfCode.Factories
{
    public class DayFactory : IDayFactory
    {
        private readonly IEnumerable<IDay> _days;
        public DayFactory(IEnumerable<IDay> days)
        {
            _days = days;
        }

        public ErrorOr<IDay> GetDay(DayEnum dayEnum)
        {
            var day = _days.FirstOrDefault(d => d.Day == dayEnum);

            if (day == null)
            {
                return Error.NotFound(description: "Day not found");
            }

            return ErrorOrFactory.From(day);
        }
    }
}

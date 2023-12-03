namespace AdventOfCode.Helpers
{
    public interface IFileHelper
    {
        IEnumerable<string> GetFileLines(string filename);
    }
}

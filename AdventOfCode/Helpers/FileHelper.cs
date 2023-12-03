namespace AdventOfCode.Helpers
{
    public class FileHelper : IFileHelper
    {
        private const string Directory = @"C:\Temp\AdventOfCode\";
        public IEnumerable<string> GetFileLines(string filename)
        {
            var lines = File.ReadAllLines($"{Directory}{filename}");
            return lines;
        }
    }
}

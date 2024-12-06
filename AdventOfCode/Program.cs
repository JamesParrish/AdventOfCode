using AdventOfCode;
using AdventOfCode.Days;
using AdventOfCode.Factories;
using AdventOfCode.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{

    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        var processor = host.Services.GetRequiredService<IProcessor>();
        processor.Process();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddTransient<IDayFactory, DayFactory>();
                services.AddTransient<IProcessor, Processor>();
                services.AddTransient<IFileHelper, FileHelper>();
                services.AddTransient<IDay, Day1>();
                services.AddTransient<IDay, Day2>();
            });
    }
}
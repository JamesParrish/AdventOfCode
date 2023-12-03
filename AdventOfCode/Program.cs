using AdventOfCode.Days;
using AdventOfCode.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IDay, Day1>(); ;
builder.Services.AddTransient<IFileHelper, FileHelper>(); ;

var app = builder.Build();

Console.WriteLine("Hello, World!");

app.Services.GetService<IDay>().Process1Star();
app.Services.GetService<IDay>().Process2Star();


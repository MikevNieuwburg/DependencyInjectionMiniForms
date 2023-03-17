using Microsoft.Extensions.DependencyInjection;
using MiniFormsConsole.Core;
using MiniFormsConsole.Decode;
using MiniFormsConsole.TextReplace;

public static class Program
{
    public static void Main(string[] args)
    {
        var provider = ServiceRegistration.RegisterServices();
        Console.WriteLine("Sample");
        var serviceRunner = provider.GetRequiredService<ServiceRunner>();
        var replace = provider.GetRequiredService<TextReplace>();
        var decode = provider.GetRequiredService<Decode>();
        replace.Order = serviceRunner.ServicesCount();
        decode.Order = serviceRunner.ServicesCount();

        serviceRunner.Add(replace);
        serviceRunner.Add(decode);
        serviceRunner.Remove(decode);
        serviceRunner.RunServices();


    }
}
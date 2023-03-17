using Microsoft.Extensions.DependencyInjection;

public static class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<IService1, ServiceA>();
        services.AddSingleton<IService2, ServiceB>();
        services.AddSingleton<IService3, ServiceC>();
        services.AddTransient<IService, ServiceA>();
        services.AddTransient<IService, ServiceB>();
        services.AddTransient<IService, ServiceC>();
        services.AddTransient<SampleClass>();

        var serviceProvider = services.BuildServiceProvider();
        SampleClass classUsage = serviceProvider.GetService<SampleClass>();
        Console.WriteLine("Sample");
        classUsage.DoSomething();
    }
}
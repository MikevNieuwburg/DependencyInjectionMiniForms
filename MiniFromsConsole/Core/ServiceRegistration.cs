using Microsoft.Extensions.DependencyInjection;

namespace MiniFormsConsole.Core
{
    internal static class ServiceRegistration
    {
        public static ServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IConsoleLogger,ConsoleLogger>();
            services.AddSingleton<LoggerService>();
            services.AddTransient<Encode.Encode>();
            services.AddTransient<Decode.Decode>();
            services.AddTransient<FolderIn.FolderIn>();
            services.AddTransient<FolderOut.FolderOut>();
            services.AddTransient<TextReplace.TextReplace>();
            services.AddTransient<TextToPDF.TextToPDF>();
            services.AddTransient<WordTemplate.WordTemplate>();
            services.AddSingleton<ServiceRunner>();

            return services.BuildServiceProvider();
        }
    }
}

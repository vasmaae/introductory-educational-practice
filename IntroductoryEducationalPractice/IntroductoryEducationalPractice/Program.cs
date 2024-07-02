using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace IntroductoryEducationalPractice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new();
            
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("serilog.json")
                .Build();


            services.AddSingleton<FormDebugging>()
                    .AddLogging(builder =>
                    {
                        builder.AddSerilog(new LoggerConfiguration()
                            .ReadFrom.Configuration(configuration)
                            .CreateLogger());
                    });

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<FormDebugging>());
        }
    }
}
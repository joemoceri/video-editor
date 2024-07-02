using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace VideoEditor
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                var app = serviceProvider.GetService<App>();

                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // add options
            services.AddOptions();
            services.Configure<ApplicationOptions>(Configuration.GetSection("Settings"));

            // add app and services
            services.AddTransient<App>();
        }
    }
}

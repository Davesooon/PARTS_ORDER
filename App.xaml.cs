using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PARTS_ORDER.Database;
using PARTS_ORDER.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PARTS_ORDER
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                    configHost.AddJsonFile("appsettings.json", optional: true);
                })
                .ConfigureServices(services =>
                {
                    services.AddScoped<IDatabaseInitializer, DatabaseInitializer>();
                    services.AddScoped<IDatabaseFunctions, DatabaseFunctions>();
                    services.AddTransient<Login>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();

            await host.StartAsync();
        }
    }
}

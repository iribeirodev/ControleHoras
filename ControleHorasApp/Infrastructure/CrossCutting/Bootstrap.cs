using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ControleHorasApp.Services;
using ControleHorasApp.Repository;

namespace ControleHorasApp.InfraStructure
{
    /// <summary>
    /// Dependency Injection
    /// </summary>
    public class Bootstrap
    {
        public static IServiceProvider GetServiceProvider() =>
            CreateHostBuilder().Build().Services;

        private static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<FormPrincipal>();
                    services.AddTransient<TaskService>();
                    services.AddTransient<LogService>();
                    services.AddTransient<TarefaRepository>();
                });


    }
}

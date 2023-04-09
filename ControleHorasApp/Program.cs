using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ControleHorasApp.InfraStructure.CrossCutting;
using ControleHorasApp.InfraStructure;
using ControleHorasApp.InfraStructure.Migrations;

namespace ControleHorasApp
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var exceptionHandler = new ExceptionHandler();
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                exceptionHandler.HandleExceptionAsync((Exception)args.ExceptionObject).Wait();
            };

            Application.ThreadException += (sender, args) =>
            {
                exceptionHandler.HandleExceptionAsync(args.Exception).Wait();
            };

            var serviceProvider = Bootstrap.GetServiceProvider();
            SqliteSnapshot.RunMigration();

            Application.Run(serviceProvider.GetRequiredService<FormPrincipal>());
        }
    }
}

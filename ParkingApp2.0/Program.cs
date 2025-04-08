using Aplication.Interface;
using Infra.Connection;
using Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ParkingApp2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddSingleton<DatabaseConnection>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IEstacionamentoRepository, EstacionamentoRepository>();
            services.AddScoped<IRelatorioRepositoy, RelatorioRepository>();

            // Registrar os formulários
            services.AddTransient<FrmPricipal>();
            services.AddTransient<FrmParkingApp>();
            services.AddTransient<FrmFiltrarDatas>();

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<FrmParkingApp>();
            Application.Run(mainForm);     
        }
    }
}
using FrutosElqui.Persistencia;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.Bancos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FrutosElqui.Escritorio
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder().ConfigureServices(((_, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        "Data Source=DESKTOP-159BML6\\LOCALMSSQL;Initial Catalog=FrutosElquiCore;Integrated Security=True", optionsBuilders =>
                        {
                            optionsBuilders.MigrationsAssembly("FrutosElqui.Persistencia");
                            optionsBuilders.EnableRetryOnFailure(10);
                        }));
                services.AddMediatR(typeof(ListaDeBancos.Handler));
                services.AddScoped<MainFrame>();
            }));
            var host = builder.Build();
            using var scope = host.Services.CreateScope();
            try
            {
                var services = scope.ServiceProvider;
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = services.GetRequiredService<MainFrame>();
                Application.Run(frm);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

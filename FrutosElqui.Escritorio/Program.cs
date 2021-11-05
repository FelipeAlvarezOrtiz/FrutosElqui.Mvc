using FrutosElqui.Persistencia;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;
using FrutosElqui.Core.Usuarios;
using FrutosElqui.Negocio.Misc.Bancos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            var builder = BuildHost();
            var host = builder.Build();
            using var scope = host.Services.CreateScope();
            try
            {
                var services = scope.ServiceProvider;
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = services.GetRequiredService<Login>();
                Application.Run(frm);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",optional:false,reloadOnChange:true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?? "Production"}.json",optional:true)
                .AddEnvironmentVariables();
        }

        private static IHostBuilder BuildHost()
        {
            return Host.CreateDefaultBuilder().ConfigureAppConfiguration((_, configBuilder) =>
            {
                BuildConfig(configBuilder);
            }).ConfigureServices(ConfigurarServicios);
        }

        private static void ConfigurarServicios(HostBuilderContext context,IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    context.Configuration.GetConnectionString("Conexion"), optionsBuilders =>
                    {
                        optionsBuilders.MigrationsAssembly("FrutosElqui.Persistencia");
                        optionsBuilders.EnableRetryOnFailure(10);
                    }));
            services.AddDefaultIdentity<AppUser>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Lockout.MaxFailedAccessAttempts = 5;
            }).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddMediatR(typeof(ListaDeBancos.Handler));
            services.AddScoped<Login>();
        }

    }
}

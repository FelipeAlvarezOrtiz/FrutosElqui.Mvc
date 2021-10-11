using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(FrutosElqui.Mvc.Areas.Identity.IdentityHostingStartup))]
namespace FrutosElqui.Mvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
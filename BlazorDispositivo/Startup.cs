using BlazorDispositivo.Services;

namespace BlazorDispositivo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<DeviceContext>();
            services.AddScoped<DeviceService>();
        }
    }
}

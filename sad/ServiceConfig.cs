using Microsoft.Extensions.DependencyInjection;

namespace YourProjectNamespace
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
    }
}

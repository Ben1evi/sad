using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace YourProjectNamespace
{
    public static class RouteConfig
    {
        public static void Configure(IRouteBuilder routes)
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Test}/{action=Index}/{id?}");
        }

        internal static void Configure(IEndpointRouteBuilder endpoints)
        {
            throw new NotImplementedException();
        }
    }
}

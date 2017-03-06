using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppInsights.Startup))]
namespace AppInsights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

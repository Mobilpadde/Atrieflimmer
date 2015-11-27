using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Atrieflimren.Startup))]
namespace Atrieflimren
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

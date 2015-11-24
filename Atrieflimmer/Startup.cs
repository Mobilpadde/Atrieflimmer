using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Atrieflimmer.Startup))]
namespace Atrieflimmer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

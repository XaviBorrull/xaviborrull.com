using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xaviborrull.Startup))]
namespace xaviborrull
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

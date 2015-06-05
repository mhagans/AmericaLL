using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmericaLittleLeaders.Startup))]
namespace AmericaLittleLeaders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

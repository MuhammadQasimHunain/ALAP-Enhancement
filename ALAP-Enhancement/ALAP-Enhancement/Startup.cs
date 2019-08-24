using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALAP_Enhancement.Startup))]
namespace ALAP_Enhancement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

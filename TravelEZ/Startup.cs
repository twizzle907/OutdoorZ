using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelEZ.Startup))]
namespace TravelEZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ventas_aspnet.Startup))]
namespace Ventas_aspnet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

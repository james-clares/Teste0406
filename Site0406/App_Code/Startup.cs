using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Site0406.Startup))]
namespace Site0406
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

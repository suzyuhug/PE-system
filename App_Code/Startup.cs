using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PEsystem.Startup))]
namespace PEsystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

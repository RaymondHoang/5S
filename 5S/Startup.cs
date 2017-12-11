using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5S.Startup))]
namespace _5S
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

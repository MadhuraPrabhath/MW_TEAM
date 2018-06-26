using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMGame.Startup))]
namespace SMGame
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

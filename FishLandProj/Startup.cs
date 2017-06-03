using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishLandProj.Startup))]
namespace FishLandProj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

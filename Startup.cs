using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IAmTheLastJedi.Startup))]
namespace IAmTheLastJedi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

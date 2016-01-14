using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CCCRM.Startup))]
namespace CCCRM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

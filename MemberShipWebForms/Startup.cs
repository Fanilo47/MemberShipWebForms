using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberShipWebForms.Startup))]
namespace MemberShipWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

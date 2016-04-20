using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authorization.Startup))]
namespace Authorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

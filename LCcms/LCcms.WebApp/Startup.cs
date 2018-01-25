using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LCcms.WebApp.Startup))]
namespace LCcms.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

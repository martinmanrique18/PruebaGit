using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appMVC4.Startup))]
namespace appMVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

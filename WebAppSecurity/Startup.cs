using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSecurity.Startup))]
namespace WebAppSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

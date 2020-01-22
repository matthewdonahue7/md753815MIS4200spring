using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(md753815MIS4200spring.Startup))]
namespace md753815MIS4200spring
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

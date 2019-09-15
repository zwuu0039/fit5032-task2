using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_9._14.Startup))]
namespace _9._14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

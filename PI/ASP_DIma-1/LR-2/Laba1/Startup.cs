using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laba1.Startup))]
namespace Laba1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

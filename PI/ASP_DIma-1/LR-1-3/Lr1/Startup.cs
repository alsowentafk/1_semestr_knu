using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lr1.Startup))]
namespace Lr1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

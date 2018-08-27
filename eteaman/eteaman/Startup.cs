using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eteaman.Startup))]
namespace eteaman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

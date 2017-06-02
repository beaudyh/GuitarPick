using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuitarPick.Startup))]
namespace GuitarPick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

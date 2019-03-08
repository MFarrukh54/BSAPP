using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSAPP.Startup))]
namespace BSAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

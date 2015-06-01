using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSACAdmin.Startup))]
namespace SSACAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

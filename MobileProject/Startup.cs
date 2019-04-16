using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileProject.Startup))]
namespace MobileProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

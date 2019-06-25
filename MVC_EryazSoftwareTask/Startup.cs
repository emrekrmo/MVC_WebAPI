using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_EryazSoftwareTask.Startup))]
namespace MVC_EryazSoftwareTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

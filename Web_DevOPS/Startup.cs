using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_DevOPS.Startup))]
namespace Web_DevOPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebClientLb2.Startup))]
namespace WebClientLb2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

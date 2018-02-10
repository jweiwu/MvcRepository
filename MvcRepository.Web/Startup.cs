using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRepository.Web.Startup))]
namespace MvcRepository.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

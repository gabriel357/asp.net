using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProva.Startup))]
namespace MvcProva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

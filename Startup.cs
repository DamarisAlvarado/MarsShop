using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProyecto.Startup))]
namespace MVCProyecto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

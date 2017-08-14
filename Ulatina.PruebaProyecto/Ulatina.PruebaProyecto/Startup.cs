using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.PruebaProyecto.Startup))]
namespace Ulatina.PruebaProyecto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

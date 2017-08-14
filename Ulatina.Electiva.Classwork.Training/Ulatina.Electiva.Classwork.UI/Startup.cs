using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.Electiva.Classwork.UI.Startup))]
namespace Ulatina.Electiva.Classwork.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

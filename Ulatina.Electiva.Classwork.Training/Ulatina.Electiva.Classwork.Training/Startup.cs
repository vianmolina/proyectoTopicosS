using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.Electiva.Classwork.Training.Startup))]
namespace Ulatina.Electiva.Classwork.Training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

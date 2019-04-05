using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCcliente.Startup))]
namespace MVCcliente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

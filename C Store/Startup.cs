using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C_Store.Startup))]
namespace C_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

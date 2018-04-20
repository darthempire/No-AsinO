using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(No_AsinO.Startup))]
namespace No_AsinO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

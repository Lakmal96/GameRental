using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameRental.Startup))]
namespace GameRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

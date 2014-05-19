using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AduClub.Startup))]
namespace AduClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

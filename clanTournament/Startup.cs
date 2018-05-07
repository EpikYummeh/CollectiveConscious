using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clanTournament.Startup))]
namespace clanTournament
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

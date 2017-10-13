using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketSysteem.Startup))]
namespace TicketSysteem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalWard_Leo.Startup))]
namespace HospitalWard_Leo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

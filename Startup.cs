using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBMSPHARMACYMANAGEMENTSYSTEM.Startup))]
namespace DBMSPHARMACYMANAGEMENTSYSTEM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

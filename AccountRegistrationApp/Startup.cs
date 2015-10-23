using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountRegistrationApp.Startup))]
namespace AccountRegistrationApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

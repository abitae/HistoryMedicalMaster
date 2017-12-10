using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HistoryMedicalWebMVC.Startup))]
namespace HistoryMedicalWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

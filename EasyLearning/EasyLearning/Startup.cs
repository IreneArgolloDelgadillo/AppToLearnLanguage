using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute("EasyLearningConfig", typeof(EasyLearning.Startup))]
namespace EasyLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

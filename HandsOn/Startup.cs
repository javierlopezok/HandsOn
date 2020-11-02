using HandsOn;
using HandsOn.PresentationLogic;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace HandsOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureIoC(app);         
        }

        private void ConfigureIoC(IAppBuilder app)
        {
            IocContainer.Setup(app);
        }
    }
}
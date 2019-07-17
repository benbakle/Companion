using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Companion
{
    public partial class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            Spa(services);
            Mvc(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            SetEnvironment(app, env);
            SinglePage(app, env);
            Mvc(app);
        }
    }
}

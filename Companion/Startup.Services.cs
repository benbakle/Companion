using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Companion
{
    public partial class Startup
    {
        static void Spa(IServiceCollection services)
        {
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "wwwroot/build";
            });
        }

        static void Mvc(IServiceCollection services)
        {
            services.AddMvc(op =>
            {
                //IgnoreODataControllerForSwagger(op);
            })
            .AddJsonOptions(options =>
            {

                options.SerializerSettings.Converters.Add(
                    new Newtonsoft.Json.Converters.StringEnumConverter());
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SampleBLClass;

namespace PinoyWish.Web.BL
{
    public static class SampleServiceExtensions
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddTransient<IClass1, Class1>();
        }
    }
}

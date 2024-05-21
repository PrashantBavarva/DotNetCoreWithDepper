using Irock.PatientHealthApp.Serivces.Interfaces;
using Irock.PatientHealthApp.Serivces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Irock.PatientHealthApp.Serivces
{
    public static class ServicesExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IUserService),typeof(UserService));
            services.AddTransient(typeof(IMessageService),typeof(MessageService));
            return services;
        }
    }
}

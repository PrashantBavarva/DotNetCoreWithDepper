using Irock.PatientHealthApp.Repository.Interfaces;
using Irock.PatientHealthApp.Repository.Interfaces.Base;
using Irock.PatientHealthApp.Repository.Repository;
using Irock.PatientHealthApp.Repository.Repository.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Irock.PatientHealthApp.Repository
{
    public static class RepositoryExtention
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository), typeof(BaseRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IMessageRepository), typeof(MessageRepository));

            return services;
        }
    }
}
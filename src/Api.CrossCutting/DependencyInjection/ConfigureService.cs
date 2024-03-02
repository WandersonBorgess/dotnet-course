using Api.Domain.Interfaces.Services.Exercise;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IExerciseService, ExerciseService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}

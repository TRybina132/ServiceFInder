using Microsoft.Extensions.DependencyInjection;

namespace ServiceFInder.ServiceScopes.Scopes
{
    public class Singleton : IScope
    {
        public void Add(IServiceCollection services, Type abstraction, Type realization) =>
            services.AddSingleton(abstraction, realization);
    }
}

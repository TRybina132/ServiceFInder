using Microsoft.Extensions.DependencyInjection;

namespace ServiceFInder.ServiceScopes.Scopes
{
    public class Scoped : IScope
    {
        public void Add(IServiceCollection services, Type abstraction, Type realization) =>
            services.AddScoped(abstraction, realization);   
    }
}

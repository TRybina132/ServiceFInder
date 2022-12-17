using Microsoft.Extensions.DependencyInjection;

namespace ServiceFInder.ServiceScopes.Scopes
{
    public class Transient : IScope
    {
        public void Add(IServiceCollection services, Type abstraction, Type realization) =>
            services.AddTransient(abstraction, realization);
    }
}

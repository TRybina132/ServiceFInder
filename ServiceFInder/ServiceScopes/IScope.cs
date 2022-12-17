using Microsoft.Extensions.DependencyInjection;

namespace ServiceFInder.ServiceScopes
{
    public interface IScope
    {
        public void Add(IServiceCollection services, Type abstraction, Type realization);
    }
}

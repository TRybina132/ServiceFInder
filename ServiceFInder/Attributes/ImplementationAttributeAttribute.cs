using Microsoft.Extensions.DependencyInjection;
using ServiceFInder.ServiceScopes;

namespace ServiceFInder.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ImplementationAttributeAttribute : Attribute
    {
        private readonly IScope scope;
        private readonly Type abstraction;

        public Type Abstraction => abstraction;

        public void AddToCollcetion(IServiceCollection services, Type realization) =>
            scope.Add(services, abstraction, realization);

        public ImplementationAttributeAttribute(
            Type abstraction,
            Scope scope)
        {
            this.abstraction = abstraction;
            this.scope = ScopeFactory.GetScope(scope);
        }
    }
}

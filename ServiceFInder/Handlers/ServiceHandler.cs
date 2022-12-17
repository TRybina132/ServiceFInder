using Microsoft.Extensions.DependencyInjection;
using ServiceFInder.Attributes;
using System.Reflection;

namespace ServiceFInder.Handlers
{
    public static class ServiceHandler
    {
        private static void AddService(Type realization, IServiceCollection services)
        {
            RealizationAttribute? realizationAttr =
                realization.GetCustomAttribute<RealizationAttribute>();

            realizationAttr?.AddToCollcetion(services, realization);
        }

        private static List<Type> FindAllRealizations(Assembly assembly)
        {
            var realizations = assembly
                .GetTypes()
                .Where(t => t.IsDefined(typeof(RealizationAttribute)));

            return realizations.ToList();
        }

        public static void DetectServices(this IServiceCollection services,Assembly assembly)
        {
            var realizations = FindAllRealizations(assembly);
            foreach(var realization in realizations)
                AddService(realization, services);
        }
    }
}

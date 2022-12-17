using ServiceFInder.ServiceScopes.Scopes;

namespace ServiceFInder.ServiceScopes
{
    public enum Scope
    {
        Transient,
        Scoped,
        Singletone
    }

    //  Factory for scope
    public static class ScopeFactory
    {
        private static IScope Transient => new Transient();
        private static IScope Scoped => new Scoped();
        private static IScope Singleton => new Singleton();

        public static IScope GetScope(Scope scope)
        {
            switch (scope)
            {
                case Scope.Transient: return Transient;
                case Scope.Scoped: return Scoped;
                case Scope.Singletone: return Singleton;
                default: return Transient;
            }
        }
    }
}

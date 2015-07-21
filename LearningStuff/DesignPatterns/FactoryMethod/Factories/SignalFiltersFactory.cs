using FactoryMethod.Filters;

namespace FactoryMethod.Factories
{
    public abstract class SignalFiltersFactory
    {
        public abstract SignalFilter CreateSignalFilter();
    }
}

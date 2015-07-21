using FactoryMethod.Filters;

namespace FactoryMethod.Factories
{
    public class LowPassFactory : SignalFiltersFactory
    {
        public override SignalFilter CreateSignalFilter()
        {
            return new LowPassSignalFilter();
        }
    }
}

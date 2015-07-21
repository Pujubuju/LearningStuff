using FactoryMethod.Filters;

namespace FactoryMethod.Factories
{
    public class HighPassFactory : SignalFiltersFactory
    {
        public override SignalFilter CreateSignalFilter()
        {
            return new HighPassSignalFilter();
        }
    }
}

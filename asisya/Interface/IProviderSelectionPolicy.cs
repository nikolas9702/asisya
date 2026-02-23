using ProviderOptimizer.Domain;

namespace ProviderOptimizer.API.Interface
{
    public interface IProviderSelectionPolicy
    {
        Provider? Select(List<Provider> providers);

    }
}

using ProviderOptimizer.Domain;

namespace ProviderOptimizer.API.Interface
{
    public class DistanceRatingSelectionPolicy : IProviderSelectionPolicy
    {
        public Provider? Select(List<Provider> providers)
        {
            return providers
                .Where(p => !p.IsBusy)
                .OrderBy(p => p.DistanceKm)
                .ThenByDescending(p => p.Rating)
                .FirstOrDefault();
        }
    }

}

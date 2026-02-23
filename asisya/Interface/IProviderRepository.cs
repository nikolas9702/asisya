using ProviderOptimizer.Domain;

namespace ProviderOptimizer.API.Interface
{
    public interface IProviderRepository
    {
        Task<List<Provider>> GetAvailableAsync();
        Task<Provider?> GetByIdAsync(Guid id);
        Task SaveChangesAsync();
    }
}

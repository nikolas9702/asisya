using ProviderOptimizer.API.Interface;
using ProviderOptimizer.Domain;

namespace ProviderOptimizer.API.Model
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly AppDbContext _context;

        public ProviderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Provider>> GetAvailableAsync()
        {
            return await _context.Providers
                .Where(p => !p.IsBusy)
                .ToListAsync();
        }

        public async Task<Provider?> GetByIdAsync(Guid id)
        {
            return await _context.Providers.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

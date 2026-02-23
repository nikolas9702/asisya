using ProviderOptimizer.API.DTO;
using ProviderOptimizer.API.Interface;
using ProviderOptimizer.API.Request;

namespace ProviderOptimizer.API.Controller
{
    public class AssignProviderUseCase
    {
        private readonly IProviderRepository _repository;
        private readonly IProviderSelectionPolicy _policy;

        public AssignProviderUseCase(
            IProviderRepository repository,
            IProviderSelectionPolicy policy)
        {
            _repository = repository;
            _policy = policy;
        }

        public async Task<ProviderResponseDto> ExecuteAsync(AssignProviderRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var providers = await _repository.GetAvailableAsync();

            var selected = _policy.Select(providers);

            if (selected == null)
                throw new Exception("No providers available");

            selected.Assign();

            await _repository.SaveChangesAsync();

            return new ProviderResponseDto
            {
                Id = selected.Id,
                DistanceKm = selected.DistanceKm,
                Rating = selected.Rating
            };
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProviderOptimizer.API.Controller
{
    [ApiController]
    [Route("api/providers")]
    public class ProvidersController : ControllerBase
    {
        private readonly AssignProviderUseCase _useCase;

        public ProvidersController(AssignProviderUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> Assign(/*[FromBody] AssignProviderRequest request*/)
        {
            try
            {
                //var result = await _useCase.ExecuteAsync(request);
                return Ok("hillll");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

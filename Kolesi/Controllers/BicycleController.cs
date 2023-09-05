using Kolesi.BL.Dto;
using Kolesi.BL.IServices;
using Kolesi.BL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Kolesi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BicycleController : ControllerBase
    {
        private readonly ILogger<BicycleController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IBicycleService _bicycleService;

        public BicycleController(ILogger<BicycleController> logger, IBicycleService bicycleService, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _bicycleService = bicycleService;
        }

        [HttpGet]
        [Authorize]
        public Task<BicycleDto> Get()
        {
            return _bicycleService.GetFirst();
        }
    }
}
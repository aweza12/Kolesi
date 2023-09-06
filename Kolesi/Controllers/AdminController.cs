using Kolesi.BL.Dto;
using Kolesi.BL.IServices;
using Kolesi.BL.Services;
using Kolesi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kolesi.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<BicycleController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IAdminService _adminService;

        public AdminController(ILogger<BicycleController> logger, IAdminService adminService, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _adminService = adminService;
        }

        [HttpGet("Users")]
        [Authorize(Roles = "Admin")]
        public async Task<List<UserDto>> Get()
        {
            return await _adminService.GetUsers();
        }
    }
}

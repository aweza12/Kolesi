using AutoMapper;
using Kolesi.BL.Dto;
using Kolesi.BL.IServices;
using Kolesi.DL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Kolesi.WebAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        public AuthController(UserManager<User> userManager, IMapper mapper, IAuthService authService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _authService = authService;
        }
        [HttpPost("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
        {
            if (userRegistration == null || !ModelState.IsValid)
                return BadRequest();

            var user = _mapper.Map<User>(userRegistration);
            var result = await _userManager.CreateAsync(user, userRegistration.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return BadRequest(new RegistrationResponseDto { Errors = errors });
            }

            await _userManager.AddToRoleAsync(user, "User");

            return StatusCode(201);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserAuthDto userAuthDto)
        {
            var user = await _userManager.FindByNameAsync(userAuthDto.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, userAuthDto.Password))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });

            var signingCredentials = _authService.GetSigningCredentials();
            var claims = await _authService.GetClaims(user);
            var tokenOptions = _authService.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }
    }
}

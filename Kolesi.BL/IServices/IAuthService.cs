using Kolesi.DL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.BL.IServices
{
    public interface IAuthService
    {
        public SigningCredentials GetSigningCredentials();
        public Task<List<Claim>> GetClaims(User user);
        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims);
    }
}

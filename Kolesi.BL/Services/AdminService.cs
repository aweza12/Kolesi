using AutoMapper;
using Kolesi.BL.Dto;
using Kolesi.BL.IServices;
using Kolesi.DL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.BL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;
        public AdminService(IMapper mapper,IConfiguration configuration, UserManager<User> userManager)
        {
            _mapper = mapper;
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<List<UserDto>> GetUsers()
        {
            return _mapper.Map<List<UserDto>>(await _userManager.Users.ToListAsync());
        }
    }
}

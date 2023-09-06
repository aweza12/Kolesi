using Kolesi.BL.Dto;
using Kolesi.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.BL.IServices
{
    public interface IAdminService
    {
        public Task<List<UserDto>> GetUsers();
    }
}

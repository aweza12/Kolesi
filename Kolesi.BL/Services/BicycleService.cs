using Kolesi.BL.Dto;
using Kolesi.DL.Entities;
using Kolesi.DL.IRepositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.BL.Services
{
    public class BicycleService
    {
        private readonly IBicyclesRepository _bicyclesRepository;
        public readonly IConfiguration _configuration;

        public BicycleService(IConfiguration configuration, IBicyclesRepository bicyclesRepository)
        {
            _configuration = configuration;
            _bicyclesRepository = bicyclesRepository;
        }

        public async Task<BicycleDto> GetFirst()
        {
            var model = await _bicyclesRepository.GetFirst();

            BicycleDto dto = new BicycleDto();
            dto.Name = model.Name;
            dto.Id = model.Id;

            return dto;
        }
    }
}

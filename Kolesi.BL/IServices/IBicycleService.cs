using Kolesi.BL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.BL.IServices
{
    public interface IBicycleService
    {
        Task<BicycleDto> GetFirst();
    }
}

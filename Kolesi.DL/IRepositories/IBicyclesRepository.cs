using Kolesi.DL.Entities;
using Kolesi.DL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.IRepositories
{
    public interface IBicyclesRepository : IBaseRepository
    {
        Task<Bicycle> GetFirst();
    }
}

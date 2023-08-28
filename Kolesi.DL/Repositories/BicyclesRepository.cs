using Kolesi.DL.Entities;
using Kolesi.DL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.Repositories
{
    public class BicyclesRepository : IBicyclesRepository
    {
        private readonly KolesiDbContext _kolesiDbContext;

        public BicyclesRepository(KolesiDbContext kolesiDbContext)// : base(kolesiDbContext)
        {
            this._kolesiDbContext = kolesiDbContext;
        }

        public async Task<Bicycle> GetFirst()
        {
            return await _kolesiDbContext.Bicycles.FirstOrDefaultAsync();
        }
    }
}

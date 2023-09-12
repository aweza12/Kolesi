using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.Entities.Interfaces
{
    public abstract class BaseDetail : BaseDbModel
    {
        public required string Name { get; set; }

        public string? Description { get; set; }
        public string? ItemCode { get; set; }
        public int Weight { get; set; }
        public string? Color { get; set; }
        public required Manufacturer Manufacturer { get; set; }
    }
}

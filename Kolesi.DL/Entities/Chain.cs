using Kolesi.DL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.Entities
{
    public class Chain : BaseDetail
    {
        public int Links { get; set; }
        public int Speed { get; set; }
    }
}

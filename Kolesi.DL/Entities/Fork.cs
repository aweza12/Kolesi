using Kolesi.DL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.Entities
{
    public class Fork : BaseDetail
    {
        public int Length { get; set; }
        public string Type { get; set; }
    }
}

using Kolesi.DL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL.Entities
{
    public class Bicycle : BaseDbModel
    {
        public string Name { get; set; }

        public Frame? Frame { get; set; }
        public Fork? Fork { get; set; }
        public Wheel? FrontWheel { get; set; }
        public Wheel? RearWheel { get; set; }
        public Chain? Chain { get; set; } 
    }
}

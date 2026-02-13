using System;
using System.Collections.Generic;
using System.Text;

namespace SULFURBuildGenerator
{
    class Attachment
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public double SpreadAdd { get; set; }

        public double MovingAccuracy { get; set; }

        public double MovementSpeedMult { get; set; }

        public double ADSCritChance { get; set; }

        public double DamageMult { get; set; }
    }
}
